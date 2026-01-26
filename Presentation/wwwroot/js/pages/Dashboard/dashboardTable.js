import { LoadData } from '../../shared/api/dataService.js';
import { TASK_PRIORITY_CLASS_MAP } from "../../shared/config/index.js";
import {
    createTableSkeleton,
    createTableHeader,
    createTableRows,
    handleEmptyState,
    applyTaskPriorityStyles
} from '../../shared/dom/table/index.js';






export async function renderDashboardTable(tableConfig = {}, formAdd) {

    let { container, table, tbody } = createTableSkeleton({ headers: tableConfig.headers, reset: true });

    const data = await LoadData(tableConfig.url);
    console.log('Data loaded:', data);

    if (handleEmptyState(data, container)) return;

    createTableHeader(tableConfig.title, formAdd);
    createTableRows(tbody, data, tableConfig.columns);
    applyTaskPriorityStyles(tbody, TASK_PRIORITY_CLASS_MAP);
}

import { LoadData } from '../../shared/api/dataService.js';
import { TASK_PRIORITY_CLASS_MAP } from "../../shared/config/index.js";
import {
    createTableSkeleton,
    createTableHeader,
    createSearchBar,
    createTableRows,
    handleEmptyState,
    applyTaskPriorityStyles
} from '../../shared/dom/table/index.js';






export async function renderDashboardTable(tableConfig = {}, func) {

    let { container, table, tbody } = createTableSkeleton({ headers: tableConfig.headers, reset: true });

    const data = await LoadData(tableConfig.url);

    if (handleEmptyState(data, container)) return;

    createSearchBar(tableConfig.title, func);
    createTableHeader(tableConfig.title, func);
    createTableRows(tbody, data, tableConfig.columns);
    applyTaskPriorityStyles(tbody, TASK_PRIORITY_CLASS_MAP);
}

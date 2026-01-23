import { LoadData } from '../../shared/api/dataService.js';
import { TASK_PRIORITY_CLASS_MAP } from "../../shared/config/index.js";
import {
    ensureTableSkeleton,
    renderTableRows,
    renderEmptyState,
    applyTaskPriorityStyles
} from '../../shared/dom/table/index.js';






export async function renderDashboardTable(tableConfig = {}) {

    let { container, table, tbody } = ensureTableSkeleton({ headers: tableConfig.headers, reset: true });

    const data = await LoadData(tableConfig.url);
    console.log('Data loaded:', data);

    if (renderEmptyState(data, container)) return;

    renderTableRows(tbody, data, tableConfig.columns);
    applyTaskPriorityStyles(tbody, TASK_PRIORITY_CLASS_MAP);
}

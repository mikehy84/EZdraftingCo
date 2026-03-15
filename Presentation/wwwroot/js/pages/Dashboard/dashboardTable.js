import { LoadData } from '../../shared/dataService/apiCalls.js';
import { TASK_PRIORITY_CLASS_MAP } from "../../shared/configs/uis/ui.configs.js";
import {
    createTableSkeleton,
    createTableHeader,
    createSearchBar,
    createTableRows,
    handleEmptyState,
    applyTaskPriorityStyles
} from '../../shared/dom/tables/index.js';






export async function renderDashboardTable(tableConfig = {}, func) {

    let { container, table, tbody } = createTableSkeleton(
        {
            headers: tableConfig.headers,
            actions: tableConfig.actions,
            reset: true
        }
    );

    const data = await LoadData(tableConfig.url);
    console.log(data);

    if (handleEmptyState(data, container)) return;

    createSearchBar(tableConfig.title, func);
    createTableHeader(tableConfig.title, func);
    createTableRows(tbody, data, tableConfig.columns);
    applyTaskPriorityStyles(tbody, TASK_PRIORITY_CLASS_MAP);
}
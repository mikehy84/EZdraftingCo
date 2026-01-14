import { renderSearch } from '../../shared/ui/search.js';
import { renderAddBtn } from '../../shared/ui/button.js';
import { LoadData } from '../../data/dataService.js';
import {
    ensureTableSkeleton,
    renderTableRows,
    renderEmptyState,
    applyTableStyles
} from '../../shared/table/index.js';




export async function renderDashboardTable(tableConfig = {}) {

    let { container, table, tbody } = ensureTableSkeleton({ headers: tableConfig.headers, reset: true });

    const data = await LoadData(tableConfig.url);
    console.log('Data loaded:', data);

    renderSearch(tableConfig.title);
    renderAddBtn(tableConfig.title);

    if (renderEmptyState(data, container)) return;

    renderTableRows(tbody, data, tableConfig.columns);
    applyTableStyles(tbody);
}






export async function addNewPerson() {
    renderAddBtn();
    if (!DASHBOARD_TABLE_CONTAINER) return;
}
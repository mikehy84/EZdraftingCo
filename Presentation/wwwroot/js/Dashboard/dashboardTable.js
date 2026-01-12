import { renderSearch } from '../Shared/search.js';
import { renderAddBtn } from '../Shared/button.js';
import { LoadData } from '../Shared/dataService.js';
import {
  ensureTableSkeleton,
  renderTableRows,
  renderEmptyState
} from '../Shared/table/index.js';




export async function renderDashboardTable(tableConfig = {}) {

    let { container, table, tbody } = ensureTableSkeleton({ headers: tableConfig.headers, reset: true });

    const data = await LoadData(tableConfig.url);
    console.log('Data loaded:', data);

    renderSearch(tableConfig.title);
    renderAddBtn(tableConfig.title);

    if (renderEmptyState(data, container)) return;

    renderTableRows(tbody, data, tableConfig.columns);
}






export async function addNewPerson() {
    renderAddBtn();
    if (!DASHBOARD_TABLE_CONTAINER) return;
}
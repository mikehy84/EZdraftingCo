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

    if (renderEmptyState(data, container)) return;

    renderTableRows(tbody, data, tableConfig.columns);
    applyTableStyles(tbody);
}

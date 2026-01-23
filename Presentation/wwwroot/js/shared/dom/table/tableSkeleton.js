

/**
 * Ensures a table exists inside container with:
 * - table element (created once)
 * - thead built once using headers
 * - tbody created if missing
 * Returns { table, tbody }
 */

export function ensureTableSkeleton({ headers, tableClass = 'table__table' }, { reset = true } = {}) {
    const container = document.querySelector('#table__container');

    if (!container) {
        console.warn('Dashboard table container not found');
        throw new Error('container is required');
    }

    container.classList.add('table__container--visible');

    // 🔥 FULL RESET
    if (reset) {
        container.innerHTML = '';
    }

    // CREATE TABLE
    const table = document.createElement('table');
    table.classList.add(tableClass);
    container.appendChild(table);

    // CREATE THEAD
    const thead = document.createElement('thead');
    const headRow = document.createElement('tr');

    headers.forEach(text => {
        const th = document.createElement('th');
        th.textContent = text;
        headRow.appendChild(th);
    });

    thead.appendChild(headRow);
    table.appendChild(thead);

    // CREATE TBODY
    const tbody = document.createElement('tbody');
    table.appendChild(tbody);

    // ADD LOADER
    const loader = document.createElement('div');
    loader.classList.add('loader');
    loader.id = 'table__loader';
    container.appendChild(loader);

    return { container, table, tbody };
}
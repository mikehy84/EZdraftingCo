
export function onSearchInput(e) {
    const query = e.target.value.toLowerCase().trim();

    const rows = document.querySelectorAll('.dashboard__table tbody tr');

    rows.forEach(row => {
        const nameCell = row.cells[0];
        const companyCell = row.cells[1];

        if (!nameCell && !companyCell) return;

        const name = nameCell?.textContent.toLowerCase() ?? '';
        const company = companyCell?.textContent.toLowerCase() ?? '';

        row.style.display =
            name.includes(query) || company.includes(query)
                ? ''
                : 'none';
    });
}


export function renderSearch() {
    const container = document.querySelector('.dashboard__container');
    if (!container) return;

    // Prevent duplicates
    if (container.querySelector('.table__header')) return;

    const div = document.createElement('div');
    div.classList.add('table__header');

    const title = document.createElement('h5');
    title.textContent = "Contacts' List";
    title.classList.add('table__headerTitle');

    const searchInput = document.createElement('input');
    searchInput.type = 'text';
    searchInput.name = 'search';
    searchInput.id = 'searchInput';
    searchInput.placeholder = 'Search contacts';
    searchInput.classList.add('table__searchInput');
    searchInput.setAttribute('aria-label', 'Search contacts by name');

    // attach listener
    searchInput.addEventListener('input', onSearchInput);

    div.prepend(searchInput);
    div.prepend(title);
    container.prepend(div);
}
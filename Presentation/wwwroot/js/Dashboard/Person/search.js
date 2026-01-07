
export function onSearchInput(e) {
    const query = e.target.value.toLowerCase().trim();

    const rows = document.querySelectorAll('.person__table tbody tr');

    rows.forEach(row => {
        const nameCell = row.cells[0];
        const phoneCell = row.cells[1];
        const companyCell = row.cells[3];

        if (!nameCell && !companyCell) return;

        const name = nameCell?.textContent.toLowerCase() ?? '';
        const phone = phoneCell?.textContent.toLowerCase() ?? '';
        const company = companyCell?.textContent.toLowerCase() ?? '';

        row.style.display =
            name.includes(query) || phone.includes(query) || company.includes(query)
                ? ''
                : 'none';
    });
}


export function renderSearch() {
    const container = document.querySelector('#container');
    if (!container) return;

    // Prevent duplicates
    if (container.querySelector('.person__header')) return;

    const div = document.createElement('div');
    div.classList.add('person__header');

    const title = document.createElement('h6');
    title.textContent = "Contacts' List";
    title.classList.add('person__title');

    const searchInput = document.createElement('input');
    searchInput.type = 'text';
    searchInput.name = 'search';
    searchInput.id = 'searchInput';
    searchInput.placeholder = 'Search contacts';
    searchInput.classList.add('person__searchInput');
    searchInput.setAttribute('aria-label', 'Search contacts by name');

    // attach listener
    searchInput.addEventListener('input', onSearchInput);

    div.prepend(searchInput);
    div.prepend(title);
    container.prepend(div);
}
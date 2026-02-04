import { createBtn } from '../elements/index.js';
import { BUTTON_CONFIGS } from '../../config/index.js';
import { divBuilder } from '../elements/index.js';

export function onSearchInput(e) {
    const query = e.target.value.toLowerCase().trim();

    const rows = document.querySelectorAll('.table__table tbody tr');

    rows.forEach(row => {
        const firstCell = row.cells[0];
        const secondCell = row.cells[1];
        const thirdCell = row.cells[3];

        if (!firstCell && !secondCell) return;

        const first = firstCell?.textContent.toLowerCase() ?? '';
        const second = secondCell?.textContent.toLowerCase() ?? '';
        const third = thirdCell?.textContent.toLowerCase() ?? '';

        row.style.display =
            first.includes(query) || second.includes(query) || third.includes(query)
                ? ''
                : 'none';
    });
}


export function createTableHeader(text, func) {
    const container = document.querySelector('#table__container');
    if (!container) return;

    // Prevent duplicates
    if (container.querySelector('.table__header')) return;

    const div = document.createElement('div');
    div.classList.add('table__header');

    const title = document.createElement('h6');
    title.textContent = text +"s List" || 'List';
    title.classList.add('table__title');

    div.prepend(title);
    container.prepend(div);
}


export function createSearchBar(text, func) {
    const container = document.querySelector('#table__container');
    if (!container) return;

    // prevent duplicates
    if (container.querySelector('.table__searchBar')) return;

    const searchBarDiv = divBuilder(container);
    searchBarDiv.classList.add('table__searchBar');

    const searchInput = document.createElement('input');
    searchInput.type = 'text';
    searchInput.name = 'search';
    searchInput.id = 'searchInput';
    searchInput.placeholder = `Search ${text}s...`;
    searchInput.classList.add('form__input');
    searchInput.setAttribute('aria-label', 'Search contacts by name');

    // attach listener
    searchInput.addEventListener('input', onSearchInput);

    createBtn(BUTTON_CONFIGS.btnAdd, searchBarDiv, func);


    searchBarDiv.prepend(searchInput);

    container.prepend(searchBarDiv);
}
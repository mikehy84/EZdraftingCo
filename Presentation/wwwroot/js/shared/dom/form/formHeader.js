

export function renderFormHeader(formTitle) {
    const container = document.querySelector('#form__container');
    if (!container) return;

    // Prevent duplicates
    if (container.querySelector('.form__header')) return;

    const div = document.createElement('div');
    div.classList.add('form__header');

    const title = document.createElement('h6');
    title.textContent = formTitle +"s List" || 'List';
    title.classList.add('form__title');

    const searchInput = document.createElement('input');
    searchInput.type = 'text';
    searchInput.name = 'search';
    searchInput.id = 'searchInput';
    searchInput.placeholder = `Search ${formTitle}s...`;
    searchInput.classList.add('form__searchInput');
    searchInput.setAttribute('aria-label', 'Search contacts by name');

    // attach listener
    searchInput.addEventListener('input', onSearchInput);

    div.prepend(searchInput);
    div.prepend(title);
    container.prepend(div);
}
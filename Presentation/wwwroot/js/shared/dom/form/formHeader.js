

export function createFormHeader(titleText) {
    const container = document.querySelector('#form__container');
    if (!container) return;

    // Prevent duplicates
    if (container.querySelector('.form__header')) return;

    const div = document.createElement('div');
    div.classList.add('form__header');

    const title = document.createElement('h6');
    title.textContent = titleText +"s List" || 'List';
    title.classList.add('form__title');

    div.prepend(title);
    container.prepend(div);
}
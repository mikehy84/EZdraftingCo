import { createSelectFromConfig } from "../../dom/elements/index.js"
import { SELECT_CONFIGS } from "../../config/selects.js"

export function addTaskForm({ headers, formClass = 'form__form' }, { reset = true } = {}) {
    const container = document.querySelector('#form__container');

    if (!container) {
        console.warn('Dashboard form container not found');
        throw new Error('container is required');
    }

    container.classList.add('form__container--visible');

    // 🔥 FULL RESET
    if (reset) {
        container.innerHTML = '';
    }

      // Form
    const form = document.createElement('form');
    form.id = 'taskDetailForm';
    form.classList.add('form__body');

    createSelectFromConfig(SELECT_CONFIGS.taskNames, form);
    createSelectFromConfig(SELECT_CONFIGS.projects, form);
    // createSelectFromConfig(SELECT_CONFIGS.phases, form);
    // createSelectFromConfig(SELECT_CONFIGS.areas, form);
    createSelectFromConfig(SELECT_CONFIGS.priorities, form);

    container.appendChild(form);

    console.log('Add Btn clicked.');

    // // CREATE TABLE
    // const table = document.createElement('table');
    // table.classList.add(tableClass);
    // container.appendChild(table);

    // // CREATE THEAD
    // const thead = document.createElement('thead');
    // const headRow = document.createElement('tr');

    // headers.forEach(text => {
    //     const th = document.createElement('th');
    //     th.textContent = text;
    //     headRow.appendChild(th);
    // });

    // thead.appendChild(headRow);
    // table.appendChild(thead);

    // // CREATE TBODY
    // const tbody = document.createElement('tbody');
    // table.appendChild(tbody);

    // // ADD LOADER
    // const loader = document.createElement('div');
    // loader.classList.add('loader');
    // loader.id = 'table__loader';
    // container.appendChild(loader);

    // return { container, table, tbody };
}

import { createSelectWithData, loadSelect, createSelectElement } from "../../dom/elements/index.js"
import { SELECT_CONFIGS } from "../../config/index.js"

export async function renderFormTaskDetail({ headers, formClass = 'form__form' }, { reset = true } = {}) {
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

    const projectSelect = await createSelectWithData(SELECT_CONFIGS.projects, form);
    const taskNameSelect = createSelectElement(SELECT_CONFIGS.taskNames);
    const prioritySelect = createSelectElement(SELECT_CONFIGS.priorities);
    const phaseSelect = createSelectElement(SELECT_CONFIGS.phases);
    const areaSelect = createSelectElement(SELECT_CONFIGS.areas);

    // Append selects to form
    form.appendChild(taskNameSelect);
    form.appendChild(prioritySelect);
    form.appendChild(phaseSelect);
    form.appendChild(areaSelect);

    // Initially disable dependent selects
    taskNameSelect.disabled = true;
    prioritySelect.disabled = true;
    phaseSelect.disabled = true;
    areaSelect.disabled = true;


    projectSelect.addEventListener('change', async (e) => {
        const projectId = e.target.value;

        prioritySelect.disabled = !projectId;
        taskNameSelect.disabled = !projectId;
        phaseSelect.disabled = !projectId;
        areaSelect.disabled = !projectId;

        await loadSelect(SELECT_CONFIGS.priorities, prioritySelect);
        await loadSelect(SELECT_CONFIGS.taskNames, taskNameSelect);
        await loadSelect(SELECT_CONFIGS.phases, phaseSelect, projectId);
        await loadSelect(SELECT_CONFIGS.areas, areaSelect, projectId);
    });


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

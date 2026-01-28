import {
    selectBuilderWithData, divBuilder, labelBuilder,
    loadSelect, textareaBuilder,
    selectBuilder,
    inputBuilder
} from "../../dom/elements/index.js"
import { SELECT_CONFIGS, FORM_CONFIGS } from "../../config/index.js"
import { createFormHeader } from "./index.js";

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

    createFormHeader('Add Task Detail');

    formBuilder(form);


    const projectSelect = await selectBuilderWithData(formConfig.project, form, null, false);
    // const projectSelect = await selectBuilderWithData(SELECT_CONFIGS.projects, form, null, false);
    // const taskNameSelect = selectBuilder(SELECT_CONFIGS.taskNames, form);
    // const prioritySelect = selectBuilder(SELECT_CONFIGS.priorities, form);
    // const phaseSelect = selectBuilder(SELECT_CONFIGS.phases, form);
    // const areaSelect = selectBuilder(SELECT_CONFIGS.areas, form);

    // projectSelect.addEventListener('change', async (e) => {
    //     const projectId = e.target.value;

    //     prioritySelect.disabled = !projectId;
    //     taskNameSelect.disabled = !projectId;
    //     phaseSelect.disabled = !projectId;
    //     areaSelect.disabled = !projectId;

    //     await loadSelect(formConfig.priority, prioritySelect);
    //     await loadSelect(formConfig.taskName, taskNameSelect);
    //     await loadSelect(formConfig.phase, phaseSelect, projectId);
    //     await loadSelect(formConfig.area, areaSelect, projectId);
    // });

    container.appendChild(form);

    console.log('Add Btn clicked.');
}



async function buildField(fieldConfig, parentDom) {
  switch (fieldConfig.type) {
    case 'input':
      return inputBuilder(fieldConfig, parentDom);

    case 'textarea':
      return textareaBuilder(fieldConfig, parentDom);

    case 'select':
      return selectBuilder(
        fieldConfig,
        parentDom
      );
  }
}


const formConfig = FORM_CONFIGS.taskDetailForm;

async function formBuilder(formDom) {

    for (const field of Object.values(formConfig)) {
        const div = divBuilder(formDom);
        const label = labelBuilder(field.label, div);
        await buildField(field, div);
    }
};

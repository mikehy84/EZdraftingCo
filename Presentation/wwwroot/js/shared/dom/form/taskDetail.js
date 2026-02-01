import {
  divBuilder, labelBuilder,
  loadSelect, textareaBuilder,
  selectBuilder,
  inputBuilder, resetFields
} from "../../dom/elements/index.js"
import { SELECT_CONFIGS, FORM_CONFIGS } from "../../config/index.js"
import { createFormHeader } from "./index.js";


const formConfig = FORM_CONFIGS.taskDetailForm;

export async function renderFormTaskDetail({ headers, formClass = 'form__form' }, { reset = true } = {}) {
  const container = document.querySelector('#form__container');

  if (!container) {
    console.warn('Dashboard form container not found');
    throw new Error('container is required');
  }

  container.classList.add('form__container--visible');

  // FULL RESET
  if (reset) {
    container.innerHTML = '';
  }

  // Form
  const formDom = document.createElement('form');
  formDom.id = 'taskDetailForm';
  formDom.classList.add('form__body');

  createFormHeader('Add Task Detail');

  const refs = await formBuilder(formConfig, formDom);

  await loadSelect(SELECT_CONFIGS.projects, refs.project, null);

  // handle project change
  refs.project.addEventListener('change', async (e) => {

    const projectId = e.target.value;

    resetFields(refs);

    // load dependent selects
    await loadSelect(SELECT_CONFIGS.phases, refs.phase, projectId);
    await loadSelect(SELECT_CONFIGS.areas, refs.area, projectId);
    await loadSelect(SELECT_CONFIGS.taskNames, refs.taskName);
    await loadSelect(SELECT_CONFIGS.priorities, refs.priority);
    await loadSelect(SELECT_CONFIGS.persons, refs.assignee);
  });

  container.appendChild(formDom);
}


async function buildField(fieldConfig, parentDom) {
  switch (fieldConfig.type) {
    case 'select':
      return selectBuilder(fieldConfig, parentDom, fieldConfig.disabled ?? false);

    case 'input':
      return inputBuilder(fieldConfig, parentDom);

    case 'textarea':
      return textareaBuilder(fieldConfig, parentDom);
  }
}


async function formBuilder(formConfig, formDom) {
  const refs = {};

  // Object.entries(formConfig) => converts the object into an array of [key, value] pairs.
  // [
  //   ['title',   { type:'input', ... }],
  //   ['project', { type:'select', ... }],
  //   ['phase',   { type:'select', ... }],
  //   ['area',    { type:'select', ... }]
  // ]

  // [fieldKey, field] => destructuring each pair into key and value
  // so => const [fieldKey, field] = ['project', {...}];
  // means => fieldKey = 'project'; field = { type:'select', select: SELECT_CONFIGS.projects }

  for (const [fieldKey, field] of Object.entries(formConfig)) {
    const div = divBuilder(formDom, 'form__field');

    // label: handle select label vs input label
    const labelConfig = field.label;
    if (labelConfig)
      labelBuilder(labelConfig, div);

    const el = await buildField(field, div);

    // store reference
    refs[fieldKey] = el;
  }

  console.log('form refs:', refs);

  return refs;
}
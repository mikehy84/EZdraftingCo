import {
  divBuilder, labelBuilder,
  loadSelect, textareaBuilder,
  selectBuilder,
  inputBuilder, resetFields,
  createBtn
} from "../../dom/elements/index.js"
import { FORM_CONFIGS } from "../../config/index.js"
import { createFormHeader } from "./index.js";



export async function renderFormTaskDetail({ reset = true } = {}) {

  const formConfig = FORM_CONFIGS.taskDetailForm;

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

  createFormHeader('New Task');

  const refs = await formBuilder(formConfig, formDom);

  await loadSelect(formConfig.project, refs.project, null);

  // handle project change
  refs.project.addEventListener('change', async (e) => {

    const projectId = e.target.value;

    resetFields(refs);

    // load dependent selects
    await loadSelect(formConfig.phase, refs.phase, projectId);
    await loadSelect(formConfig.area, refs.area, projectId);
    await loadSelect(formConfig.taskName, refs.taskName);
    await loadSelect(formConfig.priority, refs.priority);
    await loadSelect(formConfig.assignee, refs.assignee);
  });

  container.appendChild(formDom);

  // createBtn(formDom, BUTTON_CONFIGS.submit);
}


async function buildField(fieldConfig, parentDom) {
  switch (fieldConfig.type) {
    case 'select':
      return selectBuilder(fieldConfig, parentDom, fieldConfig.disabled ?? false);

    case 'input':
      return inputBuilder(fieldConfig, parentDom);

    case 'textarea':
      return textareaBuilder(fieldConfig, parentDom);
    case 'button':
      return createBtn(fieldConfig.btn, parentDom );
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
    div.classList.add(`form__field--${fieldKey}`);

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
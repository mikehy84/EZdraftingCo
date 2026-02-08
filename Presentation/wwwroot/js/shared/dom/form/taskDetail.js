import {
  divBuilder, labelBuilder,
  loadSelect, textareaBuilder,
  selectBuilder,
  inputBuilder, resetFields,
  createBtn
} from "../../dom/elements/index.js"
import { FORM_CONFIGS } from "../../config/index.js"
import { createFormHeader } from "./index.js";
import { handleSubmit } from "../buttonHandlers.js";



export async function renderFormTaskDetail({ reset = true } = {}) {

  const taskDetailFormConfig = FORM_CONFIGS.taskDetailForm;

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
  formDom.method = "post";
  formDom.id = "taskDetailForm";
  formDom.enctype = "multipart/form-data";
  formDom.classList.add('form__body');

  createFormHeader('New Task');

  const refs = await formBuilder(taskDetailFormConfig, formDom);

  formDom.addEventListener('submit', async (e) => {
    e.preventDefault();
    await handleSubmit(e, refs, formDom);
    // await renderDashboardTable(TASK_TABLE, renderFormTaskDetail);
  });

  await loadSelect(taskDetailFormConfig.project, refs.project, null);

  // handle project change
  refs.project.addEventListener('change', async (e) => {

    const projectId = e.target.value;

    resetFields(refs);

    // load dependent selects
    await loadSelect(taskDetailFormConfig.phase, refs.phase, projectId);
    await loadSelect(taskDetailFormConfig.area, refs.area, projectId);
    await loadSelect(taskDetailFormConfig.taskName, refs.taskName);
    await loadSelect(taskDetailFormConfig.priority, refs.priority);
    await loadSelect(taskDetailFormConfig.assignee, refs.assignee);
  });



  container.appendChild(formDom);

  // createBtnAdd(formDom, BUTTON_CONFIGS.submit);
}


async function buildElement(ElementConfig, parentDom) {
  switch (ElementConfig.type) {
    case 'select':
      return selectBuilder(ElementConfig, parentDom, ElementConfig.disabled ?? false);

    case 'input':
      return inputBuilder(ElementConfig, parentDom);

    case 'textarea':
      return textareaBuilder(ElementConfig, parentDom);

    case 'button':
      return createBtn({ ...ElementConfig.btn, onClick: ElementConfig.onClick }, parentDom);
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
  // means => fieldKey = 'project'; fieldConfig = { type:'select', select: SELECT_CONFIGS.projects }

  for (const [fieldKey, fieldConfig] of Object.entries(formConfig)) {
    const div = divBuilder(formDom, 'form__field');
    div.classList.add(`form__field--${fieldKey}`);

    // label: handle select label vs input label
    const labelConfig = fieldConfig.label;
    if (labelConfig)
      labelBuilder(labelConfig, div);

    const el = await buildElement(fieldConfig, div);

    // store reference
    refs[fieldKey] = el;
  }

  return refs;
}

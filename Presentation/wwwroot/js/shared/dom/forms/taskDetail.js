import { loadSelect, formBuilder, resetFields } from "../builders/index.js"
import { TASK_DETAIL_FORM_CONFIGS } from "../../configs/forms/index.config.js"
import { createFormHeader } from "./index.js";
import { handleSubmit } from "../handlers/buttonHandlers.js";



export async function renderFormTaskDetail({ reset = true } = {}) {


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

  const refs = await formBuilder(TASK_DETAIL_FORM_CONFIGS, formDom);

  formDom.addEventListener('submit', async (e) => {
    e.preventDefault();
    await handleSubmit(e, refs, formDom);
    // await renderDashboardTable(TASK_TABLE_CONFIG, renderFormTaskDetail);
  });

  await loadSelect(TASK_DETAIL_FORM_CONFIGS.project, refs.project, null);

  // handle project change
  refs.project.addEventListener('change', async (e) => {

    const projectId = e.target.value;

    resetFields(refs);

    // load dependent selects
    await loadSelect(TASK_DETAIL_FORM_CONFIGS.phase, refs.phase, projectId);
    await loadSelect(TASK_DETAIL_FORM_CONFIGS.area, refs.area, projectId);
    await loadSelect(TASK_DETAIL_FORM_CONFIGS.taskName, refs.taskName);
    await loadSelect(TASK_DETAIL_FORM_CONFIGS.priority, refs.priority);
    await loadSelect(TASK_DETAIL_FORM_CONFIGS.assignee, refs.assignee);
  });



  container.appendChild(formDom);

  // createBtnAdd(formDom, BUTTON_CONFIGS.submit);
}

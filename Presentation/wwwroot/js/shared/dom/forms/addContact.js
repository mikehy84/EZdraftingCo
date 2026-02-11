import { loadSelect, formBuilder, resetFields } from "../builders/index.js"
import { ADD_CONTACT_FORM_CONFIGS } from "../../configs/forms/index.config.js"
import { createFormHeader } from "./index.js";
import { handleSubmit } from "../handlers/buttonHandlers.js";



export async function renderFormAddContact({ reset = true } = {}) {


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

  createFormHeader('New Person');

  const refs = await formBuilder(ADD_CONTACT_FORM_CONFIGS, formDom);

  formDom.addEventListener('submit', async (e) => {
    e.preventDefault();
    await handleSubmit(e, refs, formDom);
    // await renderDashboardTable(TASK_TABLE_CONFIG, renderFormTaskDetail);
  });

  await loadSelect(ADD_CONTACT_FORM_CONFIGS.company, refs.company, null);

  // handle project change
  refs.company.addEventListener('change', async (e) => {

    const companyId = e.target.value;

    resetFields(refs);

    // load dependent selects
    await loadSelect(ADD_CONTACT_FORM_CONFIGS.phase, refs.phase, companyId);
  });



  container.appendChild(formDom);

  // createBtnAdd(formDom, BUTTON_CONFIGS.submit);
}

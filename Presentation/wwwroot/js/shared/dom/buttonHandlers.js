import { apiPost, collectTaskDetailDto } from '../api/index.js';
import { TASK_TABLE } from '../config/index.js'
import { renderDashboardTable } from '../../pages/dashboard/index.js'
import {renderFormTaskDetail} from '../dom/form/index.js'



export async function handleSubmit(e, refs, formEl) {
  e.preventDefault();

  const submitBtn = formEl.querySelector('[type="submit"]');
  if (submitBtn) submitBtn.disabled = true;

  try {
    const dto = collectTaskDetailDto(refs);

    if (!dto.projectId || !dto.taskNameId || !dto.priorityId || !dto.title) {
      alert('Please fill all required fields');
      return;
    }

    const result = await apiPost('/api/taskdetails', dto);

    await renderDashboardTable(TASK_TABLE, renderFormTaskDetail);

    const container = document.querySelector('#form__container');
    // container.classList.remove('form__container--visible');
    // container.classList.add('form__container');


    resetAfterSubmit(refs);

  } catch (err) {
    console.error('Create failed:', err);
    alert('Failed to create task ❌');
  } finally {
    if (submitBtn) submitBtn.disabled = false;
    handleCancel(e);

  }
}





function resetAfterSubmit(refs) {
  // keep project selected? your choice
  // const projectId = refs.project.value;

  refs.title.value = '';
  refs.description.value = '';

  // resetSelect(refs.taskName, 'Task Name');
  // resetSelect(refs.phase, 'Phase');
  // resetSelect(refs.area, 'Area');

  refs.taskName.disabled = true;
  refs.phase.disabled = true;
  refs.area.disabled = true;
}




export function handleCancel(e) {
  e.preventDefault();
  console.log("cancel attached")

  const container = document.querySelector('#form__container');
  if (!container) return;

  container.classList.remove('form__container--visible');
  container.classList.add('form__container');
}
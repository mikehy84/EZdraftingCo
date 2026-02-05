import { TASK_TABLE } from '../config/index.js';
import { renderDashboardTable } from '../../pages/dashboard/index.js';
import { renderFormTaskDetail } from '../dom/form/index.js';

export function collectTaskDetailDto(refs) {
  return {
    taskNameId: toInt(refs.taskName?.value),
    projectId: toInt(refs.project?.value),
    phaseId: toInt(refs.phase?.value),
    areaId: toInt(refs.area?.value),
    priorityId: toInt(refs.priority?.value),

    title: (refs.title?.value ?? '').trim(),
    description: (refs.description?.value ?? '').trim(),

    estimatedHours: toInt(refs.estimatedHours?.value) ?? 0,

    // optional
    assigneeId: toInt(refs.assignee?.value),
    assignorId: toInt(refs.assignor?.value),
  };
}

function toInt(v) {
  return v === '' || v == null ? null : parseInt(v, 10);
}


import { apiPost } from './dataService.js';

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
    container.classList.remove('form__container--visible');
    container.classList.add('form__container');


    resetAfterSubmit(refs);

  } catch (err) {
    console.error('Create failed:', err);
    alert('Failed to create task ❌');
  } finally {
    if (submitBtn) submitBtn.disabled = false;
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

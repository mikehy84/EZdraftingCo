

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

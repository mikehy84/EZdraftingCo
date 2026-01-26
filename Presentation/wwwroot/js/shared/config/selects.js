export const SELECT_CONFIGS = {
  taskNames: {
    title: "Task Name",
    api: '/api/taskNames',
    columns: ['name'],
    id: 'taskNameId',
    className: 'select__taskName'
  },

  projects: {
    title: "Project",
    api: '/api/projects',
    columns: ['internalProjectNo', 'clientProjectName'],
    id: 'projectId',
    className: 'select__project'
  },

  phases: {
    title: "Phase",
    api: '/api/phases',
    columns: ['phaseNumber', 'phaseName'],
    id: 'phaseId',
    className: 'select__phase'
  },

  areas: {
    title: "Area",
    api: '/api/projectAreas',
    columns: ['name'],
    id: 'areaId',
    className: 'select__area',
    allowEmpty: true,
  },

  priorities: {
    title: "Priority",
    api: '/api/priorities',
    columns: ['name'],
    id: 'priorityId',
    className: 'select__priority'
  },

  persons: {
    title: "Assignee",
    api: '/api/persons',
    columns: ['firstName', 'lastName'],
    id: 'assigneeId',
    className: 'select__assignee',
    allowEmpty: true,
  }
};

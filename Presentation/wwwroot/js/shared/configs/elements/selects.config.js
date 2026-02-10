export const SELECT_CONFIGS = {
  taskNames: {
    title: "Task Name",
    api: '/api/taskNames',
    columns: ['name'],
    id: 'taskName',
    className: 'select__taskName'
  },

  projects: {
    title: "Project",
    api: '/api/projects',
    columns: ['internalProjectNo', 'clientProjectName'],
    id: 'project',
    className: 'select__project'
  },

  phases: {
    title: "Phase",
    api: '/api/phases',
    columns: ['phaseNumber', 'phaseName'],
    id: 'phase',
    className: 'select__phase',
    allowEmpty: true,
  },

  areas: {
    title: "Area",
    api: '/api/projectAreas',
    columns: ['name'],
    id: 'area',
    className: 'select__area',
    allowEmpty: true,
  },

  priorities: {
    title: "Priority",
    api: '/api/priorities',
    columns: ['name'],
    id: 'priority',
    className: 'select__priority'
  },

  persons: {
    title: "Assignee",
    api: '/api/persons',
    columns: ['firstName', 'lastName'],
    id: 'assignee',
    className: 'select__assignee',
    allowEmpty: true,
  }
};

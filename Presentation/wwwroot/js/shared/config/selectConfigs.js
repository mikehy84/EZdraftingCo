export const SELECT_CONFIGS = {
  taskNames: {
    api: '/api/taskNames',
    columns: ['name'],
    id: 'taskNameId',
  },

  projects: {
    api: '/api/projects',
    columns: ['internalProjectNo', 'clientProjectName'],
    id: 'projectId',
  },

  phases: {
    api: '/api/phases',
    columns: ['phaseName'],
    id: 'phaseId',
  },

  areas: {
    api: '/api/projectAreas',
    columns: ['name'],
    id: 'areaId',
    allowEmpty: true,
  },

  priorities: {
    api: '/api/priorities',
    columns: ['name'],
    id: 'priorityId',
  },

  persons: {
    api: '/api/persons',
    columns: ['firstName', 'lastName'],
    id: 'assigneeId',
    allowEmpty: true,
  }
};

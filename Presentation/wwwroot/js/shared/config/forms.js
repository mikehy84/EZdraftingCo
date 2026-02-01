import { SELECT_CONFIGS } from './index.js';

export const FORM_CONFIGS = {
  taskDetailForm: {
    project: {
      type: 'select',
      title: "Project",
      api: '/api/projects',
      columns: ['internalProjectNo', 'clientProjectName'],
      id: 'project',
      className: 'select__project',
      select: SELECT_CONFIGS.projects,
      label: { text: 'Project:', htmlFor: 'project', className: 'label--required' },
      required: true,
      onChangeKey: 'projectChanged'
    },

    priority: {
      type: 'select',
      title: "Priority",
      api: '/api/priorities',
      columns: ['name'],
      id: 'priority',
      className: 'select__priority',
      select: SELECT_CONFIGS.priorities,
      label: { text: 'Priority:', htmlFor: 'priority', className: 'label--required' },
      required: true,
      disabled: true
    },

    taskName: {
      type: 'select',
      title: "Task Name",
      api: '/api/taskNames',
      columns: ['name'],
      id: 'taskName',
      className: 'select__taskName',
      select: SELECT_CONFIGS.taskNames,
      label: { text: 'Task Name:', htmlFor: 'taskName', className: 'label--required' },
      dependsOn: 'project',
      disabled: true
    },

    phase: {
      type: 'select',
      title: "Phase",
      api: '/api/phases',
      columns: ['phaseNumber', 'phaseName'],
      id: 'phase',
      className: 'select__phase',
      select: SELECT_CONFIGS.phases,
      label: { text: 'Phase:', htmlFor: 'phase', className: 'label--required' },
      dependsOn: 'project',
      allowEmpty: true,
      disabled: true
    },

    area: {
      type: 'select',
      title: "Area",
      api: '/api/projectAreas',
      columns: ['name'],
      id: 'area',
      className: 'select__area',
      select: SELECT_CONFIGS.areas,
      label: { text: 'Area:', htmlFor: 'area', className: 'label--required' },
      dependsOn: 'project',
      allowEmpty: true,
      disabled: true
    },

    assignee: {
      type: 'select',
      title: "Assignee",
      api: '/api/persons',
      columns: ['firstName', 'lastName'],
      id: 'assignee',
      className: 'select__assignee',
      allowEmpty: true,
      select: SELECT_CONFIGS.persons,
      label: { text: 'Assignee:', htmlFor: 'assignee', className: 'label--required' },
      allowEmpty: true,
      disabled: true
    },

    title: {
      type: 'input',
      id: 'taskTitle',
      label: { text: 'Title:', htmlFor: 'taskTitle', className: 'label--required' },
      className: 'input',
      required: true
    },

    description: {
      type: 'textarea',
      id: 'taskDescription',
      label: { text: 'Description:', htmlFor: 'taskDescription', className: 'label--required' },
      className: 'textarea'
    },
  }
};

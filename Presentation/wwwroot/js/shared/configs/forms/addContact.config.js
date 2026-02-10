import { BUTTON_CONFIGS } from '../elements/index.config.js';
import { handleCancel } from '../../dom/handlers/buttonHandlers.js';


export const ADD_CONTACT_FORM_CONFIGS = {
    project: {
      type: 'select',
      title: "Project",
      api: '/api/projects',
      columns: ['internalProjectNo', 'clientProjectName'],
      id: 'project',
      className: ['form__select', 'select__project'],
      label: { text: 'Project:', htmlFor: 'project', className: 'form__label' },
      required: true,
      onChangeKey: 'projectChanged'
    },

    phase: {
      type: 'select',
      title: "Phase",
      api: '/api/phases',
      columns: ['phaseNumber', 'phaseName'],
      id: 'phase',
      className: ['form__select', 'select__phase'],
      label: { text: 'Phase:', htmlFor: 'phase', className: 'form__label' },
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
      className: ['form__select', 'select__area'],
      label: { text: 'Area:', htmlFor: 'area', className: 'form__label' },
      dependsOn: 'project',
      allowEmpty: true,
      disabled: true
    },

    priority: {
      type: 'select',
      title: "Priority",
      api: '/api/priorities',
      columns: ['name'],
      id: 'priority',
      className: ['form__select', 'select__priority'],
      label: { text: 'Priority:', htmlFor: 'priority', className: 'form__label' },
      required: true,
      disabled: true
    },

    taskName: {
      type: 'select',
      title: "Task Name",
      api: '/api/taskNames',
      columns: ['name'],
      id: 'taskName',
      className: ['form__select', 'select__taskName'],
      label: { text: 'Task Name:', htmlFor: 'taskName', className: 'form__label' },
      dependsOn: 'project',
      disabled: true
    },

    assignee: {
      type: 'select',
      title: "Assignee",
      api: '/api/persons',
      columns: ['name'],
      id: 'assignee',
      className: ['form__select', 'select__assignee'],
      allowEmpty: true,
      // select: SELECT_CONFIGS.persons,
      label: { text: 'Assignee:', htmlFor: 'assignee', className: 'form__label' },
      allowEmpty: true,
      disabled: true
    },

    title: {
      type: 'input',
      id: 'taskTitle',
      label: { text: 'Title:', htmlFor: 'taskTitle', className: 'form__label' },
      className: 'form__input',
      required: true
    },

    estimatedHours: {
      type: 'input',
      id: 'estimatedHours',
      label: { text: 'Estimated Hours:', htmlFor: 'estimatedHours', className: 'form__label' },
      className: 'form__input',
      required: true
    },

    description: {
      type: 'textarea',
      id: 'taskDescription',
      label: { text: 'Description:', htmlFor: 'taskDescription', className: 'form__label' },
      className: 'form__textarea'
    },

    submit: {
      type: 'button',
      btn: BUTTON_CONFIGS.btnSubmit
    },

    cancel: {
      type: 'button',
      btn: BUTTON_CONFIGS.btnCancel,
      onClick: handleCancel
    }
};

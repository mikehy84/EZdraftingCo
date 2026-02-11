import { BUTTON_CONFIGS } from '../elements/index.config.js';
import { handleCancel } from '../../dom/handlers/buttonHandlers.js';


export const ADD_CONTACT_FORM_CONFIGS = {
    company: {
      type: 'select',
      title: "Company",
      api: '/api/companies',
      columns: ['id', 'name', 'companyType'],
      id: 'company',
      className: ['form__select', 'select__project'],
      label: { text: 'Company:', htmlFor: 'company', className: 'form__label' },
      required: true
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

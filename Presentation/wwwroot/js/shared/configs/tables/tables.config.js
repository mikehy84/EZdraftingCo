import { BUTTON_CONFIGS } from '../elements/index.config.js';
import { handleTaskDetailUpdate } from '../../dom/forms/index.js';
import { API_ROUTES } from "../../dataService/index.js";

// Task Table headers
export const TASK_TABLE_CONFIG = {
  title: 'Task',
  name: 'task',
  url: API_ROUTES.taskAssignments.base,
  headers: ['Id', 'Project Name', 'Priority', 'Assignee', 'Estimated Hours', 'Spent Hours', 'Status', 'Created At'],
  columns: ['id', 'projectName', 'priorityName', 'assigneeName', 'estimatedHours', 'spentHours', 'taskStateName', 'createdAt']
};


// Person Table headers
export const PERSON_TABLE_CONFIG = {
  title: 'Person',
  name: 'person',
  url: API_ROUTES.persons.base,
  headers: ['Id', 'Company Name', 'Name', 'Phone', 'Email'],
  columns: ['id', 'companyName', 'name', 'phone', 'email']
};

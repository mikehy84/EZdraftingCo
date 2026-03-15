import { BUTTON_CONFIGS } from '../elements/index.config.js';
import { handleTaskDetailUpdate } from '../../dom/forms/index.js';
import { API_ROUTES } from "../../dataService/index.js";

// Task Table headers
export const TASK_TABLE_CONFIG = {
  title: 'Task',
  name: 'task',
  url: API_ROUTES.taskAssignments.base,
  headers: ['Id', 'Priority', 'Project Name', 'Task Name', 'Assignee', 'Estimated Hours', 'Spent Hours', 'Status', 'Created At'],
  columns: ['id', 'priorityName', 'projectName', 'taskName', 'assigneeName', 'estimatedHours', 'spentHours', 'taskStateName', 'createdAt']
};


export const TASK_DETAIL_TABLE_CONFIG = {
  title: 'Task Details',
  name: 'taskDetail',
  url: API_ROUTES.taskDetails.base,
  headers: ['Id', 'Priority', 'Project Name', 'Task Name', 'Title', 'Phase Number', 'Assignee', 'Estimated Hours', 'Status', 'Created At'],
  columns: ['id', 'priorityName', 'projectName', 'taskName', 'title', 'phaseNumber', 'assigneeName', 'estimatedHours', 'taskStateName', 'createdAt']
};


// Person Table headers
export const PERSON_TABLE_CONFIG = {
  title: 'Person',
  name: 'person',
  url: API_ROUTES.persons.base,
  headers: ['Id', 'Company Name', 'Name', 'Phone', 'Email'],
  columns: ['id', 'companyName', 'name', 'phone', 'email']
};

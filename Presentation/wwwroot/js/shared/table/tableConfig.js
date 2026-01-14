
// Task Table headers
export const TASK_TABLE = {
  title: 'Task',
  name: 'task',
  url: '/api/tasks',
  headers: ['Id', 'Project Name', 'Priority', 'Assignee', 'Estimated Hours', 'Spent Hours', 'Status', 'Created At'],
  columns: ['id', 'projectName', 'priorityName', 'assigneeName', 'estimatedHours', 'spentHours', 'taskStateName', 'createdAt']
};


// Person Table headers
export const PERSON_TABLE = {
  title: 'Contact',
  name: 'contact',
  url: '/api/persons',
  headers: ['Id', 'Company Name', 'Name', 'Phone', 'Email'],
  columns: ['id', 'companyName', 'name', 'phone', 'email']
};

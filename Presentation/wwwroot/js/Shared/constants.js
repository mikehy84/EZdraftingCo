
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





// Function to clear the dashboard table container
export const ifNoData = (data, elemnt) => {
  if (!Array.isArray(data) || data.length === 0) {
    elemnt.innerHTML = '<h5 style="margin: 0;">No records are currently available.</h5>';
    return false;
  }
  return true;
};
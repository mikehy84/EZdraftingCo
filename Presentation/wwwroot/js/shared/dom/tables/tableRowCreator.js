import { formatDate } from "../../dataService/apiCalls.js";
import { STATUS_CLASS_MAP } from "../../configs/uis/ui.configs.js"
import { handleTaskDetailUpdate } from "../forms/index.js";




export function createTableRows(tbody, data, columns) {
  for (const item of data) {
    const tr = document.createElement('tr');

      columns.forEach(key => {
        const td = document.createElement('td');
        td.textContent = item[key] ?? '';

        // =========================================== //
        if (key === 'taskStateName') {
          td.textContent = item[key] ?? '';
          handleStatusCell(td, item[key], STATUS_CLASS_MAP);
        }

        if (key === 'createdAt') {
          td.textContent = formatDate(item[key]);
        }

        tr.appendChild(td);
      });

      tr.addEventListener('click', () => {
        handleTaskDetailUpdate(item);
      });

      // tbody.appendChild(tr);
      tbody.prepend(tr);
  }
}


export function handleStatusCell(td, statusText, statusClassMap) {

  td.classList.add('table__td--status');

  const span = document.createElement('span');
  span.classList.add('status__span');

  const status = (statusText ?? '').toLowerCase();

  const cls = statusClassMap[status];
  if (cls) span.classList.add(cls);

  td.prepend(span);
}


export function applyTaskPriorityStyles(tbody, priorityClassMap) {
  const tds = tbody.querySelectorAll('td');

  for (const td of tds) {
    const priority = (td.textContent ?? '').toLowerCase();
    const cls = priorityClassMap[priority];
    if (cls) td.classList.add(cls);
  }
}

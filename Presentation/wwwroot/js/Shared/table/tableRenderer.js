import { formatDate } from "../../data/dataService.js";



export function renderTableRows(tbody, data, columns) {
  for (const item of data) {
    const tr = document.createElement('tr');

        columns.forEach(key => {
          const td = document.createElement('td');
          td.textContent = item[key] ?? '';

          // =========================================== //
          // Make a function from the following later on //
          if (key === 'taskStateName') {
            td.style.display = 'flex';
            td.style.alignItems = 'center';
            td.style.gap = '8px';
            const span = document.createElement('span');
            span.classList.add('status__span');

            const status = item[key]?.toLowerCase();
            switch (status) {
              case 'new':
                span.classList.add('status__span--new');
                break;
              case 'in progress':
                span.classList.add('status__span--inProgress');
                break;
              case 'paused':
                span.classList.add('status__span--paused');
                break;
              case 'canceled':
                span.classList.add('status__span--canceled');
                break;
              case 'on hold':
                span.classList.add('status__span--onHold');
                break;
              case 'completed':
                span.classList.add('status__span--completed');
                break;
              case 'closed':
                span.classList.add('status__span--closed');
                break;
            }
            td.prepend(span);
          }

          if (key === 'createdAt') {
            td.textContent = formatDate(item[key]);
          }


          tr.appendChild(td);
        });

        tbody.appendChild(tr);
  }
}


export function applyTableStyles(tbody) {
  const tds = tbody.querySelectorAll('td');

  for (const td of tds) {
    switch (td.textContent.toLowerCase()) {
      case 'urgent':
        // td.parentElement.classList.add('table__tr--urgent');
        td.classList.add('table__td--urgent');
        break;
      case 'high':
        // td.parentElement.classList.add('table__tr--high');
        td.classList.add('table__td--high');
        break;
      case 'normal':
        // td.parentElement.classList.add('table__tr--normal');
        td.classList.add('table__td--normal');
        break;
      case 'low':
        // td.parentElement.classList.add('table__tr--low');
        td.classList.add('table__td--low');
        break;
      case 'trivial':
        // td.parentElement.classList.add('table__tr--trivial');
        td.classList.add('table__td--trivial');
        break;
    }
  }
}

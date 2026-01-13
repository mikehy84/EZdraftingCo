



export function renderTableRows(tbody, data, columns) {
  for (const item of data) {
    const tr = document.createElement('tr');

        columns.forEach(key => {
            const td = document.createElement('td');
            td.textContent = item[key] ?? '';
            tr.appendChild(td);
        });

        tbody.appendChild(tr);
  }
}


export function applyTableStyles(tbody) {
  const tds = tbody.querySelectorAll('td');

  for (const td of tds) {
    switch (td.textContent) {
      case 'High':
        td.parentElement.classList.add('table__tr--high');
        break;
      case 'Urgent':
        td.parentElement.classList.add('table__tr--urgent');
        // td.classList.add('table__td--urgent');
        break;
      case 'Medium':
        td.parentElement.classList.add('table__tr--Medium');
        break;
    }
  }
}

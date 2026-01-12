



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

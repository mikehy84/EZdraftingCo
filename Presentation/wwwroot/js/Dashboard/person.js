import { apiGet } from '../Shared/apiCalls.js';



async function LoadPersons() {
    try {
        const persons = await apiGet('/api/persons/all');
        console.log(persons);
        return persons; // return data
    } catch (error) {
        console.error('Failed to load persons:', error);
    }
}


export async function renderPersonsTable() {
    const persons = await LoadPersons();
    if (!Array.isArray(persons)) return;

    const table = document.querySelector('.Dashboard__table');
    if (!table) return;

    /* ---------- THEAD (create once) ---------- */
    if (!table.querySelector('thead')) {
        const thead = document.createElement('thead');
        const headRow = document.createElement('tr');

        const headers = ['Name', 'Date Of Birth', 'Company Name', 'Job Title'];

        headers.forEach(text => {
            const th = document.createElement('th');
            th.textContent = text;
            headRow.appendChild(th);
        });

        thead.appendChild(headRow);
        table.appendChild(thead);
    }

    /* ---------- TBODY (get or create) ---------- */
    let tbody = table.querySelector('tbody');
    if (!tbody) {
        tbody = document.createElement('tbody');
        table.appendChild(tbody);
    }

    /* ---------- CLEAR & RENDER ROWS ---------- */
    tbody.innerHTML = '';

    persons.forEach(p => {
        const tr = document.createElement('tr');

        const tdName = document.createElement('td');
        tdName.textContent = ((p.firstName ?? '') + ' ' + (p.lastName ?? '')).trim();
        tr.appendChild(tdName);

        const tdDob = document.createElement('td');
        tdDob.textContent = p.dateOfBirth ?? '';
        tr.appendChild(tdDob);

        const tdCompanyName = document.createElement('td');
        tdCompanyName.textContent = p.companyName ?? '';
        tr.appendChild(tdCompanyName);

        const tdJobTitle = document.createElement('td');
        tdJobTitle.textContent = p.jobTitle ?? '';
        tr.appendChild(tdJobTitle);

        tbody.appendChild(tr);
    });
}








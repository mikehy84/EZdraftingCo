




async function LoadPersons() {
    try {
        const persons = await apiGet('/api/persons/all');
        console.log(persons);
        return persons; // return data
    } catch (error) {
        console.error('Failed to load persons:', error);
    }
}

async function apiGet(url) {
    const res = await fetch(url);

    if (!res.ok) {
        throw new Error(`HTTP ${res.status}`);
    }

    return res.json();
}

// call it safely
document.addEventListener('DOMContentLoaded', async () => {
    let persons = await LoadPersons();


    const table = document.querySelector('.Dashboard__table');

    /* ---------- THEAD ---------- */
    const thead = document.createElement('thead');
    const headRow = document.createElement('tr');

    const headers = ['Name', 'Date Of Birth', 'Email', 'Job Title'];

    headers.forEach(text => {
        const th = document.createElement('th');
        th.textContent = text;
        headRow.appendChild(th);
    });

    thead.appendChild(headRow);
    table.appendChild(thead);


    /* ---------- TBODY ---------- */
    const tbody = document.createElement('tbody');

    persons.forEach(p => {
        const tr = document.createElement('tr');

        const tdName = document.createElement('td');
        tdName.textContent = p.firstName + ' ' + p.lastName ?? '';
        tr.appendChild(tdName);

        const tdPhone= document.createElement('td');
        tdPhone.textContent = p.dateOfBirth ?? '';
        tr.appendChild(tdPhone);



        tbody.appendChild(tr);
    });

    table.appendChild(tbody);

});






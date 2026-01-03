import { apiGet } from '../../Shared/apiCalls.js';
import { renderSearch } from './search.js';
import { showLoader, hideLoader } from '../../Shared/loader.js';



async function LoadPersons() {

    showLoader();

    try {
        const persons = await apiGet('/api/persons');

        console.log(persons);
        return persons;
    } catch (error) {
        console.error('Failed to load persons:', error);
        return [];
    } finally {
        hideLoader();
    }
}



export async function renderPersonsTable() {

    const container = document.querySelector('.person__container');
    container.style.display = "flex";

    const persons = await LoadPersons();
    renderSearch();
    renderAddBtn();

    if (!Array.isArray(persons)) return;



    container.style.backgroundColor = "var(--TableBackgroundDark)";
    container.style.boxShadow = "var(--TableBoxShadowDark)";

    if (!container) return;




    /* ---------- TABLE (create once) ---------- */
    let table = container.querySelector('table');
    if (!table) {
        table = document.createElement('table');
        table.classList.add('person__table');
        container.appendChild(table);
    }


    /* ---------- THEAD (create once) ---------- */
    if (!table.querySelector('thead')) {
        const thead = document.createElement('thead');
        const headRow = document.createElement('tr');

        const headers = ['Name', 'Phone Number', 'Email', 'Company Name'];

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

        const tdPhone = document.createElement('td');
        tdPhone.textContent = p.phone ?? '';
        tr.appendChild(tdPhone);

        const tdEmail = document.createElement('td');
        tdEmail.textContent = p.email ?? '';
        tr.appendChild(tdEmail);

        const tdCompanyName = document.createElement('td');
        tdCompanyName.textContent = p.companyName ?? '';
        tr.appendChild(tdCompanyName);

        tbody.appendChild(tr);
    });
}



async function renderAddBtn() {
    //const container = document.querySelector('#person__container');
    const personHeader = document.querySelector('.person__header');
    if (!personHeader) return;

    const addbtn = document.querySelector('.btn_add');
    if (!addbtn) {
        const btnAdd = document.createElement('button');
        btnAdd.textContent = 'Add New Contact';
        btnAdd.type = 'submit';
        btnAdd.classList.add('btn_add');

        personHeader.append(btnAdd);
    }
    return;
}


export async function addNewPerson() {

    renderAddBtn();

    const container = document.querySelector('.person__container');
    if (!container) return;
}
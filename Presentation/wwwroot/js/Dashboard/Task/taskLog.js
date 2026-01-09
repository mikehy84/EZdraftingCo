import { apiGet } from '../../Shared/apiCalls.js';
import { renderSearch } from '../../Shared/search.js';
import { renderAddBtn } from '../../Shared/button.js';
import { showLoader, hideLoader } from '../../Shared/loader.js';


const API_URL = '/api/tasks';

async function LoadData(url) {
    showLoader();

    try {
        return await apiGet(url);
    } catch (error) {
        console.error('Failed to load data:', error);
        return [];
    } finally {
        hideLoader();
    }
}




async function getDataHeaders(url) {
    const data = await LoadData(url);

    if (!Array.isArray(data) || data.length === 0) return [];

    return Object.keys(data[0]);
}












export async function renderTaskLogTable() {

    const container = document.querySelector('#table__container');

    container.classList.add('table__container--visible');

    const data = await LoadData(API_URL);

    renderSearch();
    renderAddBtn();

    if (!Array.isArray(data)) container.innerHTML = '<h5 style="margin: 0;">No records are currently available.</h5>';
    console.log(data);

    if (!container) return;

    /* ---------- TABLE (create once) ---------- */
    let table = container.querySelector('table');
    if (!table) {
       table = document.createElement('table');
       table.classList.add('table__table');
       container.appendChild(table);
    }

    /* ---------- THEAD (create once) ---------- */
    if (!table.querySelector('thead')) {
       const thead = document.createElement('thead');
       const headRow = document.createElement('tr');

        // const headers = await getDataHeaders(API_URL);
        const headers = ['Id', 'Project Name', 'Priority', 'Assignee', 'Estimated Hours', 'Spent Hours', 'Status', 'Created At'];

       headers.forEach(text => {
           const th = document.createElement('th');
           th.textContent = text;
           headRow.appendChild(th);
       });

       thead.appendChild(headRow);
       table.appendChild(thead);
    }

    ///* ---------- TBODY (get or create) ---------- */
    //let tbody = table.querySelector('tbody');
    //if (!tbody) {
    //    tbody = document.createElement('tbody');
    //    table.appendChild(tbody);
    //}

    ///* ---------- CLEAR & RENDER ROWS ---------- */
    //tbody.innerHTML = '';

    //persons.forEach(p => {
    //    const tr = document.createElement('tr');

    //    const tdName = document.createElement('td');
    //    tdName.textContent = ((p.firstName ?? '') + ' ' + (p.lastName ?? '')).trim();
    //    tr.appendChild(tdName);

    //    const tdPhone = document.createElement('td');
    //    tdPhone.textContent = p.phone ?? '';
    //    tr.appendChild(tdPhone);

    //    const tdEmail = document.createElement('td');
    //    tdEmail.textContent = p.email ?? '';
    //    tr.appendChild(tdEmail);

    //    const tdCompanyName = document.createElement('td');
    //    tdCompanyName.textContent = p.companyName ?? '';
    //    tr.appendChild(tdCompanyName);

    //    tbody.appendChild(tr);
    //});
}


//async function renderAddBtn() {
//    //const container = document.querySelector('#table__container');
//    const personHeader = document.querySelector('.table__header');
//    if (!personHeader) return;

//    const addbtn = document.querySelector('.btn_add');
//    if (!addbtn) {
//        const btnAdd = document.createElement('button');
//        btnAdd.textContent = 'Add New Contact';
//        btnAdd.type = 'submit';
//        btnAdd.classList.add('btn_add');

//        personHeader.append(btnAdd);
//    }
//    return;
//}


//export async function addNewPerson() {

//    renderAddBtn();

//    const container = document.querySelector('.table__container');
//    if (!container) return;
//}
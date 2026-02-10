// import { renderDashboardTable } from './Task/taskLog.js';
import { renderDashboardTable } from './index.js';
import { TASK_TABLE_CONFIG, PERSON_TABLE_CONFIG } from '../../shared/configs/tables/tables.config.js';
import { renderFormTaskDetail, renderFormAddContact } from "../../shared/dom/forms/index.js"



document.querySelector('.sidebar__list')
    .addEventListener('click', async (e) => {

        const link = e.target.closest('.sidebar__link');
        if (!link) return;

        // Remove active class from all links
        document
            .querySelectorAll('.sidebar__link--active')
            .forEach(l => l.classList.remove('sidebar__link--active'));

        // Add active class to clicked link
        link.classList.add('sidebar__link--active');

        const action = link.dataset.action;

        switch (action) {
            case PERSON_TABLE_CONFIG.name:
                document.querySelector('#table__container').innerHTML = '';
                document.querySelector('#form__container').innerHTML = '';
                const form = document.querySelector('#form__container');
                form.classList.remove('form__container--visible');
                await renderDashboardTable(PERSON_TABLE_CONFIG, renderFormAddContact);
                break;

            case 'company':
                console.log('companies clicked');
                break;

            case 'project':
                console.log('companies clicked');
                break;

            case TASK_TABLE_CONFIG.name:
                await renderDashboardTable(TASK_TABLE_CONFIG, renderFormTaskDetail);
                break;
        }
    });


    //---------- This is a partial view text, I might use this pattern for other dashboard tabs ----------//
// document.addEventListener('click', async (e) => {
//   const actionEl = e.target.closest('[data-action]');
//   if (!actionEl) return;

//   const action = actionEl.dataset.action;

//   switch (action) {
//     case 'task':
//       await loadPartial(
//         'table__container',
//         '/Admin/Dashboard/TaskDetailListPartial'
//       );
//       break;

//     case 'person':
//       await loadPartial(
//         'table__container',
//         '/Admin/Dashboard/PersonListPartial'
//       );
//       break;

//     default:
//       console.warn('Unknown action:', action);
//   }
// });





// async function loadPartial(containerId, url) {
//   const container = document.getElementById(containerId);
//   if (!container) return;

//   const res = await fetch(url, { headers: { 'X-Requested-With': 'fetch' } });

//   console.log('status:', res.status, 'redirected:', res.redirected, 'url:', res.url);
//   const html = await res.text();

//   // quick peek
//   console.log('first 200 chars:', html.slice(0, 200));

//   if (!res.ok) throw new Error(`HTTP ${res.status}`);

//   container.innerHTML = html;
// }

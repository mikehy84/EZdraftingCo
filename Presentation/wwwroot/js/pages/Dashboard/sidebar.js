// import { renderDashboardTable } from './Task/taskLog.js';
import { renderDashboardTable } from './index.js';
import { TASK_TABLE, PERSON_TABLE } from '../../shared/config/index.js';
import { renderFormTaskDetail } from "../../shared/dom/form/index.js"



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
            case PERSON_TABLE.name:
                await renderDashboardTable(PERSON_TABLE, renderForm);
                break;

            case 'company':
                console.log('companies clicked');
                break;

            case 'project':
                console.log('companies clicked');
                break;

            case TASK_TABLE.name:
                await renderDashboardTable(TASK_TABLE, renderFormTaskDetail);
                break;
        }
    });
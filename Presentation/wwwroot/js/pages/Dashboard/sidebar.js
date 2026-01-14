// import { renderDashboardTable } from './Task/taskLog.js';
import { renderDashboardTable } from './dashboardTable.js';
import { TASK_TABLE, PERSON_TABLE} from '../../shared/table/tableConfig.js';



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
                await renderDashboardTable(PERSON_TABLE);
                break;

            case 'company':
                console.log('companies clicked');
                break;

            case 'task':
                await renderDashboardTable(TASK_TABLE);
                break;
        }
    });
import { apiGet } from "../../dataService/index.js";
import { API_ROUTES } from "../../dataService/index.js";
import { divBuilder } from "../builders/index.js";

export async function handleTaskDetailUpdate(e, tr, item) {
    const container = e.target.closest('#table__container');
    console.log(container);

    const existingDetailDiv = document.querySelector(`#task-detail-${item.id}`);
    if (existingDetailDiv) {
        existingDetailDiv.remove();
        return;
    }
    const detailDiv = divBuilder(container, 'task-detail__div', `task-detail-${item.id}`);
    detailDiv.textContent = `Loading details for task ${item.id}...`;

    // const data = await apiGet(API_ROUTES.taskDetail(item.id));
    // console.log(data);


}

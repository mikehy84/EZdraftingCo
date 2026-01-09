export async function renderAddBtn() {
    //const container = document.querySelector('#table__container');
    const personHeader = document.querySelector('.table__header');
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
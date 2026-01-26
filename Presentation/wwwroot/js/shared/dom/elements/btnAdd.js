export function createBtnAdd(div, title, onClick) {
  // const tableHeader = document.querySelector('.table__header');
  if (!div) return;

  let btnAdd = document.querySelector('#addNewBtn');
  if (!btnAdd) {
    btnAdd = document.createElement('button');
    btnAdd.id = 'addNewBtn';
    btnAdd.type = 'button';
    btnAdd.classList.add('btn_add');
    div.append(btnAdd);
  }

  btnAdd.textContent = `Add New ${title}`;

  // IMPORTANT: replace old handler
  btnAdd.onclick = null;

  if (typeof onClick === 'function') {
    btnAdd.addEventListener('click', onClick);
  }
}

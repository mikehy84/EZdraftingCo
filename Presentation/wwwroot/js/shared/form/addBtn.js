



export function renderAddBtn(text = 'Add New', onClick) {
  const tableHeader = document.querySelector('.table__header');
  if (!tableHeader) return;

  let btnAdd = document.querySelector('#addNewBtn');
  if (!btnAdd) {
    btnAdd = document.createElement('button');
    btnAdd.id = 'addNewBtn';
    btnAdd.type = 'button';
    btnAdd.classList.add('btn_add');
    tableHeader.append(btnAdd);
  }

  btnAdd.textContent = `Add New ${text}`;

  // IMPORTANT: replace old handler
  btnAdd.onclick = null;

  if (typeof onClick === 'function') {
    btnAdd.addEventListener('click', onClick);
  }
}

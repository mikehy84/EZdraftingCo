export function createBtn(config, parentElement, func) {
  // const tableHeader = document.querySelector('.table__header');
  if (!parentElement) return;

  let btnAdd = document.querySelector(`#${config.id}`);
  if (!btnAdd) {
    btnAdd = document.createElement('button');
    btnAdd.id = config.id;
    btnAdd.type = 'button';
    btnAdd.classList.add(config.className);
    btnAdd.textContent = config.text;
    parentElement.append(btnAdd);
  }

  // IMPORTANT: replace old handler
  btnAdd.onclick = null;

  if (typeof func === 'function') {
    btnAdd.addEventListener('click', func);
  }
}

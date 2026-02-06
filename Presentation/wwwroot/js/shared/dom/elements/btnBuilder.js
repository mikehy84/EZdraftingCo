export function createBtn(config, parentElement, func) {
  // const tableHeader = document.querySelector('.table__header');
  if (!parentElement) return;

  let btnAdd = document.querySelector(`#${config.id}`);
  if (!btnAdd) {
    btnAdd = document.createElement('button');
    btnAdd.id = config.id;
    btnAdd.type = config.type;
    btnAdd.classList.add('btn')
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


export function createBtnAdd(config, parentElement, func) {
  // const tableHeader = document.querySelector('.table__header');
  if (!parentElement) return;

  let btnAdd = document.querySelector(`#${config.id}`);
  if (!btnAdd) {
    btnAdd = document.createElement('button');
    btnAdd.id = config.id;
    btnAdd.type = config.type;
    btnAdd.classList.add('btn')
    btnAdd.classList.add(config.className);

    const icon = document.createElement('span');
    icon.textContent = '+';
    icon.classList.add('icon__add');

    const label = document.createElement('span');
    label.textContent = config.text;

    btnAdd.append(icon, label);

    parentElement.append(btnAdd);
  }

  // IMPORTANT: replace old handler
  btnAdd.onclick = null;

  if (typeof func === 'function') {
    btnAdd.addEventListener('click', func);
  }
}

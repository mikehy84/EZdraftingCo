

export function inputBuilder(config, parentDom) {

    const input = document.createElement('input');

    if (config.className) {
        input.classList.add(config.className);
    }

    if (config.id) {
        input.id = config.id;
    }

    input.required = config.required ?? true;

    if (parentDom)
        parentDom.appendChild(input);

    return input;
}

export function resetFields(refs) {
  Object.values(refs).forEach(input => {
    if (input && input.tagName === 'INPUT') {
      input.value = '';
      }
      if (input && input.tagName === 'TEXTAREA') {
        input.value = '';
      }
  });
}
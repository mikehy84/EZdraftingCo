

export function createInputElement(config, parentDom) {
    const input = document.createElement('input');

    input.classList.add('input');

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
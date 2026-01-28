

export function divBuilder(parentDom, id = null, className = null) {
    const div = document.createElement('div');

    div.classList.add('div');
    div.classList.add(className);
    div.id = id;

    if (parentDom)
        parentDom.appendChild(div);

    return div;
}
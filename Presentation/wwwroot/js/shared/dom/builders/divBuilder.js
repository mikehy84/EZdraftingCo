

export function divBuilder(parentDom, className = null, id = null) {
    const div = document.createElement('div');

    div.classList.add(className);
    div.id = id;

    if (parentDom) parentDom.appendChild(div);

    return div;
}
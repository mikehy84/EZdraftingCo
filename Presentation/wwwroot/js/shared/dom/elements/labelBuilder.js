

export function labelBuilder(config, parentDom) {
  if (!config) throw new Error('createLabelElement: config is required');

  const label = document.createElement('label');
  label.classList.add('label');

  if (config.className) {
    label.classList.add(config.className);
  }

  if (config.htmlFor) {
    label.htmlFor = config.htmlFor;
  }

  if (config.text) {
    label.textContent = config.text;
  }

  if (parentDom) {
    parentDom.appendChild(label);
  }

  return label;
}

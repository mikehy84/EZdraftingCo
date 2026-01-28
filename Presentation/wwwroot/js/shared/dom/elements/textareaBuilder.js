export function textareaBuilder(config, parentDom) {
  if (!config) throw new Error('textareaBuilder: config is required');

  const textarea = document.createElement('textarea');
  textarea.classList.add('textarea');

  if (config.className) {
    textarea.classList.add(config.className);
  }

  if (config.id) {
    textarea.id = config.id;
  }

  if (config.placeholder) {
    textarea.placeholder = config.placeholder;
  }

  if (config.rows) {
    textarea.rows = config.rows;
  }

  if (config.cols) {
    textarea.cols = config.cols;
  }

  if (typeof config.required === 'boolean') {
    textarea.required = config.required;
  }

  if (parentDom) {
    parentDom.appendChild(textarea);
  }

  return textarea;
}

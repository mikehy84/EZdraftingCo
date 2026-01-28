import { apiGet } from '../../api/dataService.js';

export async function selectBuilderWithData(config, parentDom, id = null, disabled = true) {

  if (!config?.api) throw new Error('config.api is required');
  if (!parentDom) throw new Error('parentDom is required');

  const select = selectBuilder(config, parentDom, disabled);

  createDefaultOption(config, select);

  const data = await apiGet(config.api, id);

  const list = prepareSelectList(select, data, config);

  populateSelectOptions(select, list, config);

  parentDom.appendChild(select);

  return select;
}



export async function loadSelect(config, select, id) {

  select.innerHTML = '';
  createDefaultOption(config, select);

  const data = await apiGet(config.api, id);

  const list = prepareSelectList(select, data, config);

  populateSelectOptions(select, list, config);
}



//////////////// HELPERS ////////////////////////
export function selectBuilder(config, parentDom, disabled = true) {
  const select = document.createElement('select');

  select.classList.add('select');

  if (config.className) {
    select.classList.add(config.className);
  }

  if (config.id) {
    select.id = config.id;
  }

  select.required = config.required ?? true;
  select.disabled = disabled;

  if (parentDom)
    parentDom.appendChild(select);

  return select;
}


export function createDefaultOption(config, select) {
  const firstOpt = document.createElement('option');
  firstOpt.value = '';
  firstOpt.disabled = true;
  firstOpt.selected = true;   // default
  firstOpt.textContent = `--Select ${config.title}--`;
  select.appendChild(firstOpt);
}


export function createNoneOption(select) {
  const opt = document.createElement('option');
  opt.value = '';
  opt.textContent = 'None';
  select.appendChild(opt);
}

export function prepareSelectList(select, data, config) {
  const list = Array.isArray(data) ? data : [];

  if (config.allowEmpty || list.length === 0) {
    createNoneOption(select);
  }

  return list;
}


export function populateSelectOptions(select, list, config) {
  for (const item of list) {
    const option = document.createElement('option');

    option.value = item.id ?? item.Id ?? '';

    option.textContent = config.columns
      .map(k => item[k] ?? '')
      .filter(v => v != null && String(v).trim() !== '')
      .join(' - ');

    select.appendChild(option);
  }
}

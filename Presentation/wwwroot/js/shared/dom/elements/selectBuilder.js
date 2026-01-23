import { apiGet } from '../../api/dataService.js';

export async function createSelectFromConfig(config, parentDom) {

  if (!config?.api) throw new Error('config.api is required');
  if (!parentDom) throw new Error('parentDom is required');

    const data = await apiGet(config.api);
    console.log(data);

  const select = document.createElement('select');
  select.classList.add('form__select');
  select.id = config.id ?? '';

  // optional empty option
  if (config.allowEmpty) {
    const opt = document.createElement('option');
    opt.value = '';
    opt.textContent = 'None';
    select.appendChild(opt);
  }

  if (Array.isArray(data)) {
    for (const item of data) {
      const option = document.createElement('option');
      option.value = item.id ?? item.Id ?? '';

      option.textContent = config.columns
        .map((key) => item[key] ?? '')
        .filter((v) => String(v).trim() !== '')
        .join(' ');

      select.appendChild(option);
    }
  }

  parentDom.appendChild(select);
  return select;
}

import { selectBuilder } from './selectBuilder.js';
import { inputBuilder } from './inputBuilder.js';
import { textareaBuilder } from './textareaBuilder.js';
import { btnBuilder } from './btnBuilder.js';


export async function elementBuilder(ElementConfig, parentDom) {
  switch (ElementConfig.type) {
    case 'select':
      return selectBuilder(ElementConfig, parentDom, ElementConfig.disabled ?? false);

    case 'input':
      return inputBuilder(ElementConfig, parentDom);

    case 'textarea':
      return textareaBuilder(ElementConfig, parentDom);

    case 'button':
      return btnBuilder({ ...ElementConfig.btn, onClick: ElementConfig.onClick }, parentDom);
  }
}
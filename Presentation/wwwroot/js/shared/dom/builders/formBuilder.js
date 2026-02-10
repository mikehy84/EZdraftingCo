import { divBuilder } from "./divBuilder.js";
import { labelBuilder } from "./labelBuilder.js";
import { elementBuilder } from "./elementBuilder.js";

export async function formBuilder(formConfig, formDom) {
  const refs = {};

  // Object.entries(formConfig) => converts the object into an array of [key, value] pairs.
  // [
  //   ['title',   { type:'input', ... }],
  //   ['project', { type:'select', ... }],
  //   ['phase',   { type:'select', ... }],
  //   ['area',    { type:'select', ... }]
  // ]

  // [fieldKey, field] => destructuring each pair into key and value
  // so => const [fieldKey, field] = ['project', {...}];
  // means => fieldKey = 'project'; fieldConfig = { type:'select', select: SELECT_CONFIGS.projects }

  for (const [fieldKey, fieldConfig] of Object.entries(formConfig)) {
    const div = divBuilder(formDom, 'form__field');
    div.classList.add(`form__field--${fieldKey}`);

    // label: handle select label vs input label
    const labelConfig = fieldConfig.label;
    if (labelConfig)
      labelBuilder(labelConfig, div);

    const el = await elementBuilder(fieldConfig, div);

    // store reference
    refs[fieldKey] = el;
  }

  return refs;
}
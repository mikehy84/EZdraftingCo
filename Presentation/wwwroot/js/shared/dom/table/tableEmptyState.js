export function renderEmptyState(data, element) {
    if (!Array.isArray(data) || data.length === 0) {
        element.innerHTML =
            '<h5 style="margin: 0;">No records are currently available.</h5>';
        return true;
    }
    return false;
}

// Function to clear the dashboard table container
export const ifNoData = (data, elemnt) => {
  if (!Array.isArray(data) || data.length === 0) {
    elemnt.innerHTML = '<h5 style="margin: 0;">No records are currently available.</h5>';
    return false;
  }
  return true;
};
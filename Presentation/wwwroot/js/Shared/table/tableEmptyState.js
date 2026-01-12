export function renderEmptyState(data, element) {
    if (!Array.isArray(data) || data.length === 0) {
        element.innerHTML =
            '<h5 style="margin: 0;">No records are currently available.</h5>';
        return true;
    }
    return false;
}
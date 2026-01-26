import { showLoader, hideLoader } from '../ui/loader.js';



export async function apiGet(url, id = null) {
    try {
        const finalUrl = id ? `${url}/${id}` : url;

        const res = await fetch(finalUrl);

    if (!res.ok) {
        throw new Error(`HTTP ${res.status} - ${res.statusText}`);
    }

    return await res.json();

    } catch (err) {
        console.error(`apiGet failed for: ${url}`, err);
        return null; // safe fallback
    }
}




export async function LoadData(url) {
    showLoader();
    try {
        return await apiGet(url);
    } catch (error) {
        console.error('Failed to load data:', error);
        return [];
    } finally {
        hideLoader();
    }
}



export function formatDate(value) {
  if (!value) return '—';
  return new Date(value).toLocaleString('en-CA', {
    year: 'numeric',
    month: 'short',
    day: '2-digit',
    hour: '2-digit',
    minute: '2-digit',
  });
}

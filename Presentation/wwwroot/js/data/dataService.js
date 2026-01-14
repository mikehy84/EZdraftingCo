import { showLoader, hideLoader } from '../shared/ui/loader.js';

export async function apiGet(url) {
    const res = await fetch(url);

    if (!res.ok) {
        throw new Error(`HTTP ${res.status}`);
    }

    return res.json();
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

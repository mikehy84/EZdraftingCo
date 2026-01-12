import { showLoader, hideLoader } from './loader.js';

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

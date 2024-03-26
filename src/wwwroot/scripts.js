// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function setItem(key, value) {
    sessionStorage.setItem(key, value);
}

export function getItem(key) {
    return sessionStorage.getItem(key);
}

export function removeItem(key) {
    sessionStorage.removeItem(key);
}

export function clear() {
    sessionStorage.clear();
}

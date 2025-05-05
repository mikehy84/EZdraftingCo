window.onload = function () {
    const form = document.getElementById("userForm");
    Array.from(form.elements).forEach(el => {
        if (el.tagName === "INPUT") {
            el.disabled = true;
        }
    });

    const enableBtn = document.getElementById("enableUserForm");
    enableBtn.addEventListener("click", enableForm);
};


function enableForm() {
    const form = document.getElementById("userForm");
    const submitBtn = document.getElementById("submitUserForm");
    const enableBtn = document.getElementById("enableUserForm");
    if (form) {
        Array.from(form.elements).forEach(el => {
            if (el.tagName === "INPUT") {
                el.disabled = false;
            }
        })
    }

    submitBtn.hidden = false;
    enableBtn.hidden = true;

}


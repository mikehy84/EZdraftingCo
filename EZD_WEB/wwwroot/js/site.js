document.getElementById("services").addEventListener("click", function () {
    const target = document.getElementById("home__sec3");
    const targetPosition = target.getBoundingClientRect().top + (window.scrollY - 110);

    window.scrollTo({ top: targetPosition, behavior: "smooth" });
});


//document.getElementById("projects").addEventListener("click", function () {
//    const target = document.getElementById("home__sec4");
//    const targetPosition = target.getBoundingClientRect().top + (window.scrollY - 110);

//    window.scrollTo({ top: targetPosition, behavior: "smooth" });
//});


document.getElementById("about").addEventListener("click", function () {
    const target = document.getElementById("home__sec1");
    const targetPosition = target.getBoundingClientRect().top + (window.scrollY + 0);

    window.scrollTo({ top: targetPosition, behavior: "smooth" });
});


document.getElementById("contact").addEventListener("click", function () {
    const target = document.getElementById("home__sec4");
    const targetPosition = target.getBoundingClientRect().top + (window.scrollY - 110);

    window.scrollTo({ top: targetPosition, behavior: "smooth" });
});





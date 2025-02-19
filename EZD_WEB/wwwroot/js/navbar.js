// script.js
let prevScrollPos = window.scrollY;

window.onscroll = function () {
    const currentScrollPos = window.scrollY;
    const navbarBottom = document.getElementById("navbar__bottom");
    const navbarTop = document.getElementById("navbar__top");

    const logoBlue = document.getElementById("navbar__logo-blue");
    const logoWhite = document.getElementById("navbar__logo-white");

    console.log(navbarBottom);

    if (prevScrollPos > currentScrollPos) {
        // Scrolling up
        navbarBottom.style.transform = "translateY(0)";
        navbarBottom.style.backgroundColor = "transparent";
        navbarBottom.style.boxShadow = "0 0 0";

        logoWhite.style.display = "block";
        logoBlue.style.display = "none";

        navbarTop.style.transform = "ScaleY(0)";
        navbarTop.style.transformOrigin = "top";
    } else {
        // Scrolling down
        navbarBottom.style.transform = "translateY(2.5rem)"; /* Adjust based on navbar height */
        navbarBottom.style.backgroundColor = "var(--Gray-0)";
        navbarBottom.style.boxShadow = "0px 5px 10px var(--Gray-6)";

        logoWhite.style.display = "none";
        logoBlue.style.display = "block";

        navbarTop.style.transform = "ScaleY(1)";
        navbarTop.style.transformOrigin = "top";
    }

    prevScrollPos = 100;
};
// script.js
let prevScrollPos = window.scrollY;

window.onscroll = function () {
    const currentScrollPos = window.scrollY;
    const navbarBottom = document.getElementById("navbar__bottom");
    const navbarTop = document.getElementById("navbar__top");

    const logoBlue = document.getElementById("navbar__logo-blue");
    const logoWhite = document.getElementById("navbar__logo-white");

    const navbarMenuList = document.getElementById("navbar__menu-list");
    const navbarBottomATags = navbarMenuList.querySelectorAll(".navbar__menu-list a");
    //const navbarBottomATags = navbarMenuList.querySelectorAll(".navbar__menu-list a:link");


    if (prevScrollPos > currentScrollPos) {
        // Scrolling up
        navbarBottom.style.transform = "translateY(0)";
        navbarBottom.style.backgroundColor = "transparent";
        navbarBottom.style.boxShadow = "0 0 0";

        logoWhite.style.display = "block";
        logoBlue.style.display = "none";

        navbarTop.style.transform = "ScaleY(0)";
        navbarTop.style.transformOrigin = "top";


        navbarBottomATags.forEach(tag => {
            tag.style.color = "var(--Gray-0)";
            tag.style.transition = "color 0.3s ease-in-out";

            tag.addEventListener("mouseover", () => {
                tag.style.color = "greenyellow";
                tag.style.transition = "color 0.3s ease-in-out";
            });

            tag.addEventListener("mouseout", () => {
                tag.style.color = "var(--Gray-0)";
                tag.style.transition = "color 0.3s ease-in-out";
            });
        });

    } else {
        // Scrolling down
        navbarBottom.style.transform = "translateY(2.5rem)"; /* Adjust based on navbar height */
        navbarBottom.style.backgroundColor = "var(--Gray-0)";
        navbarBottom.style.boxShadow = "0px 5px 15px var(--Gray-8)";

        logoWhite.style.display = "none";
        logoBlue.style.display = "block";

        navbarTop.style.transform = "ScaleY(1)";
        navbarTop.style.transformOrigin = "top";

        navbarBottomATags.forEach(tag => {
            tag.style.color = "var(--Gray-9)";
            tag.style.transition = "textShadow 0.3s ease-in-out";

            tag.addEventListener("mouseover", () => {
                tag.style.color = "orangered";
                tag.style.transition = "color 0.3s ease-in-out";
            });

            tag.addEventListener("mouseout", () => {
                tag.style.color = "var(--Gray-9)";
                tag.style.transition = "color 0.3s ease-in-out";
            });
        });
    }

    prevScrollPos = 100;
};



const menuBtn = document.querySelector(".navbar__burger-btn");
let menuOpen = false;
menuBtn.addEventListener("click", () => {
    if (!menuOpen) {
        menuBtn.classList.add("open");
        document.getElementById("navbar__burger-list").style.opacity = "1";
        document.getElementById("navbar__burger-list").style.transform = "scaleY(1)";
        menuOpen = true;
    } else {
        menuBtn.classList.remove("open");
        document.getElementById("navbar__burger-list").style.opacity = "0";
        document.getElementById("navbar__burger-list").style.transform = "scaleY(0)";
        menuOpen = false;
    }
});




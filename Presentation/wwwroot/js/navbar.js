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

    const burger = document.querySelector(".navbar__burger-icon");
    const burgerBefore = document.querySelector(".navbar__burger-icon");
    const burgerAfter = document.querySelector(".navbar__burger-icon");

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

        setBurgerLine();
        burger.style.setProperty("--middleLine", "var(--BurgerIcon)");
        burgerBefore.style.setProperty("--before", "var(--BurgerIcon)");
        burgerAfter.style.setProperty("--after", "var(--BurgerIcon)");

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
                tag.style.color = "var(--LinkInWhite)";
                tag.style.transition = "color 0.3s ease-in-out";
            });

            tag.addEventListener("mouseout", () => {
                tag.style.color = "var(--Gray-9)";
                tag.style.transition = "color 0.3s ease-in-out";
            });
        });

        setBurgerLine();
        burger.style.setProperty("--middleLine", "var(--Gray-9)");
        burgerBefore.style.setProperty("--before", "var(--Gray-9)");
        burgerAfter.style.setProperty("--after", "var(--Gray-9)");
    }

    prevScrollPos = 100;
};


const menuBtn = document.querySelector(".navbar__burger-btn");
let isOpen = false;
menuBtn.addEventListener("click", () => {
    if (!isOpen) {
        menuBtn.classList.add("open");
        burger.style.backgroundColor.opacity = "0";

        document.getElementById("navbar__burger-list").style.opacity = "1";
        document.getElementById("navbar__burger-list").style.transform = "scaleY(1)";
        isOpen = true;
    } else {
        menuBtn.classList.remove("open");
        burger.style.backgroundColor.opacity = "1";

        document.getElementById("navbar__burger-list").style.opacity = "0";
        document.getElementById("navbar__burger-list").style.transform = "scaleY(0)";
        isOpen = false;
    }
});

function setBurgerLine() {
    if (!isOpen) {
        burger.style.backgroundColor.opacity = "0";
    } else {
        burger.style.backgroundColor.opacity = "1";
    }
}








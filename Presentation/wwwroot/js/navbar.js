// script.js
let prevScrollPos = window.scrollY;


window.onscroll = function () {
    const currentScrollPos = window.scrollY;
    const navbarBottom = document.querySelector(".nav__btm");
    const navbarTop = document.getElementById("nav__top");

    const logoBlue = document.getElementById("logo__blue");
    const logoWhite = document.getElementById("logo__white");

    const navbarMenuList = document.getElementById("navbar__list");
    const navbarBottomATags = navbarMenuList.querySelectorAll(".navbar__list a");

    const burger = document.querySelector(".burger__icon");
    const burgerBefore = document.querySelector(".burger__icon");
    const burgerAfter = document.querySelector(".burger__icon");

    if (prevScrollPos > currentScrollPos) {
        // Scrolling up
        navbarBottom.classList.remove('scroldown');
        navbarBottom.classList.add('scrolup');

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
        navbarBottom.classList.remove('scrolup');
        navbarBottom.classList.add('scroldown');

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


const menuBtn = document.querySelector(".burger__btn");
let isOpen = false;
menuBtn.addEventListener("click", () => {
    if (!isOpen) {
        menuBtn.classList.add("open");
        burger.style.backgroundColor.opacity = "0";

        document.getElementById("burger__list").style.opacity = "1";
        document.getElementById("burger__list").style.transform = "scaleY(1)";
        isOpen = true;
    } else {
        menuBtn.classList.remove("open");
        burger.style.backgroundColor.opacity = "1";

        document.getElementById("burger__list").style.opacity = "0";
        document.getElementById("burger__list").style.transform = "scaleY(0)";
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








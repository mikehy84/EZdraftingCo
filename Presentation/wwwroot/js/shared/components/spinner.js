$(document).ready(function () {
    // For form submission
    $("form").on("submit", function () {
        $("#loader").show();
    });

    // Optional: For link clicks
    $("a").on("click", function (e) {
        const href = $(this).attr("href");
        if (href && !href.startsWith("#") && !href.startsWith("javascript:")) {
            $("#loader").show();
        }
    });

    // Optional: For AJAX
    //$(document).ajaxStart(function () {
    //    $("#loader").show();
    //}).ajaxStop(function () {
    //    $("#loader").hide();
    //});
});




//document.addEventListener("DOMContentLoaded", function () {
//    // Show loader on form submit
//    const forms = document.querySelectorAll("form");
//    forms.forEach(form => {
//        form.addEventListener("submit", () => {
//            const loader = document.getElementById("loader");
//            if (loader) loader.style.display = "block";
//        });
//    });

//    // Show loader on link clicks (except anchors and JavaScript)
//    const links = document.querySelectorAll("a");
//    links.forEach(link => {
//        link.addEventListener("click", (e) => {
//            const href = link.getAttribute("href");
//            if (
//                href &&
//                !href.startsWith("#") &&
//                !href.startsWith("javascript:")
//            ) {
//                const loader = document.getElementById("loader");
//                if (loader) loader.style.display = "block";
//            }
//        });
//    });
//});
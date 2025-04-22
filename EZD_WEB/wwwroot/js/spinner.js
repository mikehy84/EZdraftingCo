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
//    document.getElementById("spinner").style.display = "none";
//});
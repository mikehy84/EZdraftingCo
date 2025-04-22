const projectImgs = document.querySelectorAll(".project-img");

let zoomedLayout = document.getElementById("zoomed-layout");

let zoomedImg = document.querySelector(".zoomed-img");


let zoomIsActive = false;

projectImgs.forEach((img) => {
    img.addEventListener("click", () => {

        if (!zoomIsActive) {
            zoomedImg.src = img.src;
            zoomedImg.alt = img.alt;

            zoomedLayout.style.display = "flex";
            zoomedLayout.style.cursor = "zoom-out";
            zoomedLayout.onclick = closeZoomedLayout;
            zoomedLayout.appendChild(zoomedImg);

            console.log("Clicked");

            zoomIsActive = true;
        }
    });
});



function closeZoomedLayout() {
    zoomedLayout.style.display = "none";
    zoomedLayout.removeChild(zoomedImg);
    zoomIsActive = false;
}





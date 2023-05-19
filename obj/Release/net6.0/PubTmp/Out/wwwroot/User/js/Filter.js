var Filter = document.querySelector(".filter");
var contentFilter = document.querySelector(".content-filter");
var FilterHeader = document.querySelectorAll(".filter-header");
var filterClose = document.querySelector(".filter-close");
var btnToggleFilter = document.querySelector("#btnToggleFilter");
filterClose.addEventListener("click", () => {
    Filter.classList.toggle("d-none");
    contentFilter.classList.toggle("d-none");

});
btnToggleFilter.addEventListener("click", () => {
    Filter.classList.toggle("d-none");
    contentFilter.classList.toggle("d-none");
});
FilterHeader.forEach((header) => {
    header.addEventListener("click", (e) => {
        if (window.innerWidth < 992) {
            header.nextElementSibling.classList.toggle("d-none");
            header.nextElementSibling.classList.toggle("px-3");
            contentFilter.classList.toggle("open");
        }
    });
});

// var navbarContainer = document.querySelector(".navbar-container");
// window.onscroll = () => {
//   if (window.innerWidth > 992) {
//     navbarContainer.classList.toggle("bg-white", window.scrollY > 30);
//     navbarContainer.classList.toggle("shadow", window.scrollY > 30);
//   }
// };


NiceSelect.bind(document.getElementById("MySelect"));
var MySelect = document.getElementById("MySelect").addEventListener("change", () =>
    alert(document.getElementById("MySelect").value)
);

var navbarToggler = document.getElementById("navbarToggler");
var navbarCollapse = document.getElementById("navbarCollapse");
var blurDiv = document.querySelector(".blur-div");
var closeBtn = document.querySelector(".close");
navbarToggler.onclick = () => {
    navbarCollapse.classList.add("showNav");
    document.body.classList.add("disable-scroll");
    blurDiv.classList.add("blur");
};
closeBtn.onclick = () => {
    Rest();
};
function Rest() {
    navbarCollapse.classList.remove("showNav");
    document.body.classList.remove("disable-scroll");
    blurDiv.classList.remove("blur");
}
window.onresize = () => {
    Rest();
};
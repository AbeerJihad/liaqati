let imageInput = document.getElementById('Images');
let imagesViewer = document.querySelector('.images-viewer');
const dt = new DataTransfer()
let files = [];
imageInput.addEventListener("change", ShowFiles)
function ShowFiles() {
    imagesViewer.innerHTML = '';

    files = [];
    for (var file of imageInput.files) {
        console.log(file);
        files.push(file);
        var imageUrla = URL.createObjectURL(file);
        RenderImages(imageUrla, file.name)
        //var reader = new FileReader();
        //reader.readAsDataURL(file);
        //reader.onload = () => {
        //    console.log(reda)
        //    // var imageUrla = URL.createObjectURL(file);
        //    RenderImages(reader.result, file.name)
        //}
    };

}
function DeleteFile(fileName) {
    dt.items.clear();
    files.splice(files.indexOf(files.find(file => file.name === fileName)), 1);
    files.forEach(item => {
        dt.items.add(item);
    })
    imageInput.files = dt.files;
    ShowFiles();
}
function RenderImages(imageUrl, fileName = null) {
    var imageCard = document.createElement('div');
    imageCard.className = "position-relative rounded-3 bg-white";
    imageCard.style.width = '150px';
    imageCard.style.height = '150px';
    if (fileName == null) {
        imageCard.innerHTML += `<div class="position-absolute rounded " style="inset:20px;"><img src="${imageUrl}" class="w-100 h-100" style="inset:5em;object-fit:cover" /></div>`
    } else {
        imageCard.innerHTML += `<div class="position-absolute rounded " style="inset:20px;"><img src="${imageUrl}" class="w-100 h-100" style="inset:5em;object-fit:cover" /></div><button class="btn d-flex align-items-center  justify-content-center shadow  p-0 bg-white rounded-circle position-absolute delete-btn" type="button" onclick="DeleteFile('${fileName}');"> <i class="bi bi-x"></i></button>`

    }
    imagesViewer.appendChild(imageCard)
}




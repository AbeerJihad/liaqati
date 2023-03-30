//import { getProducts, getCategories } from "./ProductModel.js";


let lstProducts = [];
let productsContainer = document.querySelector(".products-container");
c

async function getdata(categoryid) {
    productsContainer.innerHTML = "";
    lstProducts = await getProducts(categoryid);
    lstProducts.forEach((p) => RenderCards(p));
    await document.querySelectorAll(".btn-favourite").forEach((btn) => {
        btn.addEventListener("click", (e) => {
            btn.classList.toggle("text-danger");
        });
    });

}
getdata(null);

function RenderCards(product) {
    let card = document.createElement("div");
    card.className = "col-lg-4 p-2";
    card.innerHTML = ` 
        <div class="card overflow-hidden   boradius border p-0">
        <div class="position-relative box-img w-100">
            <img
              src="https://localhost:7232/${product.imgUrl}"
              height="200"
              class="position-absolute w-100 h-100 start-0 top-0 rounded-top"
              alt="..."
              onclick="alert("${product.Services.title}")"
              style="object-fit: cover"
            />
            <button
              style="width: 50px; height: 50px; top: 10px; right: 10px"
              class="rounded-pill btn-favourite   text-secondary btn position-absolute border bg-white shadow-sm rounded d-flex fw-bold justify-content-center align-items-center align-middle"
            >
              <i class="bi bi-heart-fill h3 d-block m-0 mt-1"></i>
            </button>
          </div>
          <div class="card-body g-2 p-2 mt-0">
            <div class="d-flex m-2 justify-content-between">
              <p class="card-text">#${product.Services.category.name} </p>
              <div class="rating-section">
                <i class="bi bi-star-fill text-secondary star"></i>
                <i class="bi bi-star-fill text-secondary star"></i>
                <i class="bi bi-star-fill text-secondary star"></i>
                <i class="bi bi-star-fill text-secondary star"></i>
                <i class="bi bi-star-fill text-secondary star"></i>
              </div>
            </div>
            <div class="justify-content-between">
              <div class="d-flex justify-content-between align-items-center">
                <div>
                  <p class="p-0 m-0 text-success">${product.Services.title}</p>
                  <h5 class="fw-bold text-danger mt-3">$${product.Services.price}</h5>
                </div>
                <button
                  style="width: 70px; height: 70px"
                  class="rounded-pill btn imgBackground border shadow-sm rounded d-flex fw-bold justify-content-center align-items-center align-middle"
                >
                  <i class="bi bi-cart-fill h3 d-block m-0"></i>
                </button>
              </div>
            </div>
          </div>
          </div>`;
    productsContainer.appendChild(card);
}

//window.onload = function () {

//    selectElement.addEventListener("change", (event) => {

//        table_container.innerHTML = '';

//        if (event.target.value == '-1')
//            getdata(null);
//        else
//            getdata(event.target.value);
//    });


//    formAdd.addEventListener('submit', (event) => {
//        event.preventDefault();

//        var data = new FormData();
//        data.append("Sku", formAdd.Sku.value);
//        data.append("Name", formAdd.Name.value);
//        data.append("Description", formAdd.Description.value);
//        data.append("Price", parseFloat(formAdd.Price.value));
//        data.append("IsAvailable", formAdd.IsAvailable.checked);
//        data.append("CategoryId", formAdd.CategoryId.value);
//        data.append("Category", null);


//        var payload = {
//            //Id: 0,
//            Sku: formAdd.Sku.value,
//            Name: formAdd.Name.value,
//            Description: formAdd.Description.value,
//            Price: parseFloat(formAdd.Price.value),
//            IsAvailable: formAdd.IsAvailable.checked,
//            CategoryId: formAdd.CategoryId.value,
//            Category: null
//        };

//        //addProduct(payload).then((d) => {
//        addProductForm(data).then((d) => {

//            console.table(d);

//            if (d !== undefined && d.status === 'ok') {

//                document.querySelector('#modTxtMessage').innerHTML = `A new product with id ${d.data["id"]} has been added.`;

//                getProducts(formAdd.CategoryId.value);

//                formAdd.reset();

//                myModal.toggle();

//                getdata(d.data["categoryId"]);

//            }
//            else {
//                document.querySelector('#txtMessage').innerHTML = `Error: ${d.data.title}`;
//            }

//        });

//    });


//    //getCategories();
//    //getProducts(null);

//}
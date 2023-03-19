//import { getProducts, getCategories } from "./ProductModel.js";


let lstProducts = [];
let lstCategories = [];
let productsContainer = document.querySelector(".products-container");
const selectElement = document.querySelector("#lstCategory");
const modelselectElement = document.querySelector("#CategoryId");
const formAdd = document.querySelector("#frmAdd");

async function getdata(categoryid) {
    productsContainer.innerHTML = "";
    lstProducts = await getProducts(categoryid);
    lstProducts.forEach((p) => RenderCards(p));

}
getdata(null);


getCategories().then(d => {
    lstCategories = d;
    RenderNav(selectElement);
    RenderNav(document.querySelector('#CategoryId'))
});



function RenderNav(selectElement) {
    for (element of lstCategories) {
        let li = document.createElement("option");
        li.value = element.id;
        li.innerHTML = element.name;
        selectElement.appendChild(li);
    }
}

function RenderCards(product) {
    let card = document.createElement("div");
    card.className = "card    col-lg-3 m-3 boradius shadow cardhov p-0";
    card.innerHTML = `
            <div class="position-relative">
                <img src=${product.imgUrl} height="200" class="card-img-top shadow rounded-top shadow-inset " alt="..." style="object-fit:cover; " />
                <img width="30" class="position-absolute " style="top: 10px; right: 10px"
                        src="~/images/heart-svgrepo-com (1).png" alt="" srcset="" />
            </div>
            <div class="card-body g-2 m-2 p-3">
                <p class="card-text">#type </p>
                <div class=" justify-content-between">
                    <div class=" d-flex  justify-content-between">
                        <p class="py-2 Pnametxt"> ${product.services.title}</p>
                        <div style="background-color:#ffff" id="imgBackground" class="rounded-pill shadow rounded d-inline-block fw-bold align-middle">
                            <img width="28" height="28" class="m-3" src="~/images/layer1.png" alt="" srcset="" />
                        </div>
                    </div>
                    <h5 class="fw-bold redcolor"> ${product.services.price}$</h5>
                    <div>
                    </div>
                </div>

            </div>
    `;
    productsContainer.appendChild(card);
}

window.onload = function () {

    selectElement.addEventListener("change", (event) => {

        table_container.innerHTML = '';

        if (event.target.value == '-1')
            getdata(null);
        else
            getdata(event.target.value);
    });


    formAdd.addEventListener('submit', (event) => {
        event.preventDefault();

        var data = new FormData();
        data.append("Sku", formAdd.Sku.value);
        data.append("Name", formAdd.Name.value);
        data.append("Description", formAdd.Description.value);
        data.append("Price", parseFloat(formAdd.Price.value));
        data.append("IsAvailable", formAdd.IsAvailable.checked);
        data.append("CategoryId", formAdd.CategoryId.value);
        data.append("Category", null);


        var payload = {
            //Id: 0,
            Sku: formAdd.Sku.value,
            Name: formAdd.Name.value,
            Description: formAdd.Description.value,
            Price: parseFloat(formAdd.Price.value),
            IsAvailable: formAdd.IsAvailable.checked,
            CategoryId: formAdd.CategoryId.value,
            Category: null
        };

        //addProduct(payload).then((d) => {
        addProductForm(data).then((d) => {

            console.table(d);

            if (d !== undefined && d.status === 'ok') {

                document.querySelector('#modTxtMessage').innerHTML = `A new product with id ${d.data["id"]} has been added.`;

                getProducts(formAdd.CategoryId.value);

                formAdd.reset();

                myModal.toggle();

                getdata(d.data["categoryId"]);

            }
            else {
                document.querySelector('#txtMessage').innerHTML = `Error: ${d.data.title}`;
            }

        });

    });


    //getCategories();
    //getProducts(null);

}
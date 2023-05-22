let ProductsApiResult;
let ProductContainer = document.querySelector("#ProductContainer");
let formSearch = document.querySelector("#formSearch");
let searchTearmInput = document.querySelector("#searchTearm");
let NoResult = document.querySelector("#NoResult");
let Paging = document.querySelector("#Paging");
let lstCate = document.querySelector("#lstCate");
let lstSort = document.querySelector("#lstSort");
let countofcart = document.querySelector("#countofcart");

let searchTearm = "";
let selectListCategory = "";
let SortOrder = "";
let Sortby = "";
let CurPage = 1;

async function addprotocart(id) {
    var int = await AddCart(id);
    countofcart.innerHTML = int;

}



lstCate.addEventListener('change', () => {
    selectListCategory = lstCate.value;
    getdata(null);
})
lstSort.addEventListener('change', () => {/*"MinPrice",Text="الأقل سعر
              "MaxPrice",Text="الأعلى سعر
                                            "MaxRatePercentage
                                            "MinRatePercentage*/

    if (lstSort.value === "MinPrice") {
        SortOrder = "asc";
        Sortby = "Price";
    } else if (lstSort.value === "MaxPrice") {
        SortOrder = "desc";
        Sortby = "Price";

    } else if (lstSort.value === "MaxRatePercentage") {
        SortOrder = "asc";
        Sortby = "RatePercentage";

    } if (lstSort.value === "MinRatePercentage") {
        SortOrder = "desc";
        Sortby = "RatePercentage";
    }
    getdata(null);
})
async function getdata(categoryid) {
    RenderSkeletonCards();
    var parms = {
        curPage: CurPage,
        size: 12,
        sortBy: Sortby,
        sortOrder: SortOrder,
        minPrice: null,
        maxPrice: null,
        title: "",
        categoryId: selectListCategory,
        searchTearm: searchTearm
    };
    console.log(parms)
    /*{
  "curPage": 0,
  "size": 0,
  "sortBy": "string",
  "sortOrder": "string",
  "minPrice": 0,
  "maxPrice": 0,
  "title": "string",
  "categoryId": "string",
  "searchTearm": "string"
}*/
    if (navigator.onLine) {

        ProductsApiResult = await getProducts(parms);
        ProductContainer.innerHTML = "";
        NoResult.innerHTML = "";

        if (ProductsApiResult.listOfData && ProductsApiResult.listOfData.length > 0) {
            ProductsApiResult.listOfData.forEach((p) => RenderCards(p));
        } else {
            RenderNoResult()
        }
        RenderPagination(ProductsApiResult);
        console.log(ProductsApiResult);
    } else {
        ProductContainer.innerHTML = "";

        NoResult.innerHTML = ` 
            <div class="card shadow-sm border my-5" style="max-width: 500px">
        <div class="card-body">
          <div class="d-flex justify-content-center align-items-center flex-column">
            <i class="bx bx-error text-danger" style="font-size: 100px"></i>
            <h2 class="mb-4 text-danger">لا يوجد انترنت</h2>
            <p class="h4 text-center mb-4">
تغقد اتصالك بالإنترنت ثم حاول مجددا            </p>
            
          </div>
        </div>
      </div>
         `

    }

}
//RenderSkeletonCards();
getdata(null);

function getAll() {
    CurPage = 1;
    searchTearm = "";
    getdata(null);

}

window.addEventListener('online', () => {
    getAll()
})
window.addEventListener('offline', () => {
    ProductContainer.innerHTML = "";
    NoResult.innerHTML = ` 
      <div class="card shadow-sm border my-5" style="max-width: 500px">
        <div class="card-body">
          <div class="d-flex justify-content-center align-items-center flex-column">
            <i class="bx bx-error text-danger" style="font-size: 100px"></i>
            <h2 class="mb-4 text-danger">لا يوجد انترنت</h2>
            <p class="h4 text-center mb-4">تغقد اتصالك بالإنترنت ثم حاول مجددا</p>
          </div>
        </div>
      </div>
         `

})
formSearch.addEventListener("submit", (e) => {
    e.preventDefault();
    searchTearm = searchTearmInput.value;
    getdata(null);
})
function RenderCards(Product) {
    const formatter = new Intl.NumberFormat('en-US', {
        style: 'currency', currency: 'USD',
        minimumFractionDigits: 2
    })

    console.log(Product);

    var btn2 = `
                 <button title="add to Favorite" onclick="AddFavorite('${Product.id}')" class="rounded-pill btn-favorite text-secondary btn position-absolute  bg-white  rounded d-flex fw-bold justify-content-center align-items-center align-middle">
                    <img width="25" height="25" src="/Images/heart-solid-24.png" />

                </button>
     `;

    var btn1 = `
                 <button title="add to Favorite" onclick="AddFavorite('${Product.id}')" class="rounded-pill btn-favorite text-secondary btn position-absolute  bg-white  rounded d-flex fw-bold justify-content-center align-items-center align-middle">
                    <i class="bi bi-heart-fill h4 d-block m-0 mt-1"></i>

                </button>
     `;



    var image = "";
    if (Product.images.length > 0) {
        if (Product.images.length > 1) {



            if (Product.isFavorite == 2) {
                ProdID = Product.id;
                image = ` <div id="${Product.id}" class="position-relative box-img shadow-sm border-0 w-100">
              <img src="${Product.images[1]}" class="position-absolute object-fit-cover w-100 h-100 start-0 top-0 rounded-top" alt="" onclick="">
              <img src="${Product.images[0]}" class="position-absolute object-fit-cover w-100 h-100 start-0 top-0 rounded-top" alt="" onclick="">

             ${btn2}

            </div>`



            }
            else {
                ProdID = Product.id;
                image = ` <div id="${Product.id}" class="position-relative box-img shadow-sm border-0 w-100">
              <img src="${Product.images[1]}" class="position-absolute object-fit-cover w-100 h-100 start-0 top-0 rounded-top" alt="" onclick="">
              <img src="${Product.images[0]}" class="position-absolute object-fit-cover w-100 h-100 start-0 top-0 rounded-top" alt="" onclick="">

             ${btn1}
            </div>`


            }

        } else {
            ProdID = Product.id;


            if (Product.isFavorite == 2) {
                ProdID = Product.id;
                image = ` <div id="${Product.id}" class="position-relative box-img1 shadow-sm border-0 w-100">
              <img src="${Product.images[0]}" class="position-absolute object-fit-cover w-100 h-100 start-0 top-0 rounded-top" alt="" onclick="">

             ${btn2}
            </div>`


            }
            else {
                ProdID = Product.id;
                image = ` <div id="${Product.id}" class="position-relative box-img1 shadow-sm border-0 w-100">
              <img src="${Product.images[0]}" class="position-absolute object-fit-cover w-100 h-100 start-0 top-0 rounded-top" alt="" onclick="">

             ${btn1}
            </div>`



            }




        }
    } else {
        ProdID = Product.id;

        if (Product.isFavorite == 2) {
            ProdID = Product.id;
            image = ` <div id="${Product.id}" class="position-relative box-img1 shadow-sm border-0 w-100">
              <img src="/images/default.png" class="position-absolute object-fit-cover w-100 h-100 start-0 top-0 rounded-top" alt="" onclick="">

             ${btn2}
            </div>`


        }
        else {
            ProdID = Product.id;
            image = ` <div id="${Product.id}" class="position-relative box-img1 shadow-sm border-0 w-100">
              <img src="/images/default.png" class="position-absolute object-fit-cover w-100 h-100 start-0 top-0 rounded-top" alt="" onclick="">

             ${btn1}
            </div>`



        }


    }
    if (Product.percentageRate == null) {

        rate = ` <div class="rating">
                  <div class="rating position-relative">
                    <div class="rating-upper d-flex">
                      <i class="bi bi-star-fill text-black-50"></i>
                      <i class="bi bi-star-fill text-black-50"></i>
                      <i class="bi bi-star-fill text-black-50"></i>
                      <i class="bi bi-star-fill text-black-50"></i>
                      <i class="bi bi-star-fill text-black-50"></i>
                    </div>
                    <div class="rating-lower d-flex position-absolute top-0 start-0 overflow-hidden w-0">
                      <i class="bi bi-star-fill text-warning"></i>
                      <i class="bi bi-star-fill text-warning"></i>
                      <i class="bi bi-star-fill text-warning"></i>
                      <i class="bi bi-star-fill text-warning"></i>
                      <i class="bi bi-star-fill text-warning"></i>
                    </div>
                  </div>`;


    }
    else {
        rate = `  <div class="rating">
                  <div class="rating position-relative">
                    <div class="rating-upper d-flex">
                      <i class="bi bi-star-fill text-black-50"></i>
                      <i class="bi bi-star-fill text-black-50"></i>
                      <i class="bi bi-star-fill text-black-50"></i>
                      <i class="bi bi-star-fill text-black-50"></i>
                      <i class="bi bi-star-fill text-black-50"></i>
                    </div>
                    <div class="rating-lower d-flex position-absolute top-0 start-0 overflow-hidden w-${ratePercentage}">
                      <i class="bi bi-star-fill text-warning"></i>
                      <i class="bi bi-star-fill text-warning"></i>
                      <i class="bi bi-star-fill text-warning"></i>
                      <i class="bi bi-star-fill text-warning"></i>
                      <i class="bi bi-star-fill text-warning"></i>
                    </div>
                  </div>`;
    }

    let card = document.createElement("div");

    card.className = "col p-2 p-xl-4";
    card.innerHTML = `<a href="/products/ProductDetails/${Product.id}">
          <div class="card h-100 shadow-sm overflow-hidden h-100 product-card  border p-0" >
           ${image}
            <div class="card-body g-2 p-2 mt-0" >
              <div class="d-flex m-2 justify-content-between">
                <p class="card-text m-0">${Product.categoryName}</p>
                    ${rate}
                </div>
              </div>
              <div class="justify-content-between">
                <div>
                  <div>
                    <p class="p-0 m-0 text-success" style="font-size:14px !important;">${Product.title}</p>
                  </div>
                  <div class="d-flex justify-content-between align-items-center">
                    <h5 class="fw-bold text-danger m-0">${formatter.format(Product.price)}</h5>
                     <button  title="إضافة إلى السلة" onclick="addprotocart(${Product.id})" class="rounded-pill btn imgBackground add-to-bag-btn border shadow-sm rounded d-flex fw-bold justify-content-center align-items-center align-middle">
                      <i class="bx bx-cart-add h3 d-block m-0"></i>
                    </button>
                  </div>
                </div>
              </div>
          </div>
        </div></a>  `

    ProductContainer.appendChild(card);
}



function RenderNoResult() {
    NoResult.innerHTML = "";
    let card = document.createElement("div");
    card.className = "card shadow-sm my-5 border";
    card.style.maxWidth = 500;
    card.innerHTML = ` 
        <div class="card-body ">
          <div
            class="d-flex justify-content-center align-items-center flex-column"
          >
            <i
              class="bx bx-error-circle text-main"
              style="font-size: 100px"
            ></i>
            <h2 class="mb-4 text-main">لا يوجد نتائج</h2>
            <p class="h4 text-center mb-4">
              حاول ضبط مرشحات البحث لمزيد من النتائج.
            </p>
            <div><a class="btn btn-main text-white" onclick="getAll()">عرض الكل</a></div>
          </div>
      </div>
                              `;
    NoResult.appendChild(card);

}

function RenderSkeletonCards() {
    ProductContainer.innerHTML = "";
    for (var i = 0; i < 9; i++) {
        let card = document.createElement("div");
        card.className = "col placeholder-wave p-3";
        card.innerHTML = `
          <div class="card placeholder-wave h-100 shadow overflow-hidden h-100 boradius border p-0">
            <div class="position-relative box-img w-100 placeholder"></div>
            <div class="card-body g-2 p-2 mt-0">
              <div class="d-flex m-2 justify-content-between">
                <p class="card-text placeholder"></p>
                <div class="rating w-100 placeholder"></div>
              </div>
              <div class="justify-content-between">
                <div>
                  <div>
                    <p class="p-0 m-0 text-success placeholder w-100"></p>
                  </div>
                  <div class="d-flex justify-content-between align-items-center">
                    <h5 class="fw-bold text-danger mt-3 placeholder w-100"></h5>
                  </div>
                </div>
              </div>
            </div>
          </div>
    
                              `;
        ProductContainer.appendChild(card);
    }
}
function NextPage(JsonData) {
    if (CurPage < JsonData.totalPages) {
        CurPage++;
        getdata(null);
    }
}
function PrevPage() {
    if (CurPage > 1) {
        CurPage--;
        getdata(null);

    }
}
function GetPage(index) {
    CurPage = parseInt(index);
    getdata(null);
}


async function AddFavorite(id) {

    var IsAdd = await AddFavoritesToProduct(id);
    var btn = document.querySelectorAll('.btn-favorite');
    if (IsAdd = "true") {

        //for (var i = 0; i < btn.length;i++) {

        //    btn[i].innerHTML = `
        //                          ${btn2}
        //                       `;
        //}
        getdata(null);

    }
    else if (IsAdd = "false") {
        //for (var i = 0; i < btn.length; i++) {

        //    btn[i].innerHTML = `
        //                        ${btn1}
        //                       `;
        //}
        getdata(null);
    }
    else {
        window.location = "";
    }


}

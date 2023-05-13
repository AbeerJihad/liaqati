let HealthyRecipesApiResult;
let HealthyRecipeContainer = document.querySelector("#HealthyRecipeContainer");
let Paging = document.querySelector("#Paging");
let CurPage = 1;
async function getdata(categoryid) {
    RenderSkeletonCards();
    var parms = {
        CurPage: CurPage,
        size: 12,
        dietaryType: [],
        mealType: [],
    };
    HealthyRecipesApiResult = await getHealthyRecipes(parms);
    HealthyRecipeContainer.innerHTML = "";
    if (HealthyRecipesApiResult.listOfData && HealthyRecipesApiResult.listOfData.length > 0) {

        HealthyRecipesApiResult.listOfData.forEach((p) => RenderCards(p));
    } else {
        RenderNoResult()
    }
    RenderPagination(HealthyRecipesApiResult);
    console.log(HealthyRecipesApiResult);

}
//RenderSkeletonCards();
getdata(null);


function RenderNoResult() {
    let card = document.createElement("div");
    card.className = "card shadow-sm border";
    card.style.maxWidth = 500;
    card.innerHTML = ` 
        <div class="card-body">
          <div
            class="d-flex justify-content-center align-items-center flex-column"
          >
            <i
              class="bx bx-error-circle text-primary"
              style="font-size: 100px"
            ></i>
            <h2 class="mb-4 text-primary">لا يوجد نتائج</h2>
            <p class="h4 text-center mb-4">
              حاول ضبط مرشحات البحث لمزيد من النتائج.
            </p>
            <div><a class="btn btn-primary">عرض الكل</a></div>
          </div>
      </div>
                              `;
    HealthyRecipeContainer.appendChild(card);

}

/*"listOfData": [
    {
      "imgUrl": "/Image/Product/Dumbbell3.jfif",
      "discount": 20,
      "services": {
        "title": "طقم اوزان دمبل 30 كغم",
        "description": "",
        "shortDescription": null,
        "price": 20,
        "categoryId": "4",
        "category": {
          "name": "الاجهزة الرياضية",
          "target": "المنتجات",
          "description": null,
          "id": "4"
        },
        "userId": null,
        "user": null,
        "id": "21"
      },
      "id": "21"
    },*/
function RenderCards(HealthyRecipe) {
    const formatter = new Intl.NumberFormat('en-US', {
        style: 'currency', currency: 'USD',
        minimumFractionDigits: 2
    })

    console.log(HealthyRecipe);
    let card = document.createElement("div");
    card.className = "col p-3";
    card.innerHTML = `
     <a href="/HealthyRecipes/HealthyRecipesDetiles/${HealthyRecipe.id}">
<div class="col p-1">
    <div class="card rounded-0 shadow-sm">
        <div class="position-relative  overflow-hidden image-box" style="height:300px">
            <img src="${HealthyRecipe.image}" class="card-img-top rounded-0 object-fit-cover position-absolute w-100 start-0 top-0 h-100" alt="...">
        </div>
        <div class="card-body p-0">
            <div class="d-flex justify-content-between align-items-center  px-2 title-box">
                <h6 class="card-title text-black fw-bold  m-2">
                        ${HealthyRecipe.title}
                </h6>
                <div class="d-flex justify-content-center align-items-center gap-2">
                    <a title="share" class=" border-0 bg-transparent " href="#">
                        <i class="bi bi-share fs-4 text-dark"></i>
                    </a>
                    <a title="heart" class=" border-0 bg-transparent" href="#">
                        <i class="bi bi-heart fs-4 text-dark"></i>
                    </a>
                </div>
            </div>
            <div class="d-flex justify-content-between g-0  p-2">
                <div class="d-flex">
                    <div class="rating">
                        <div class="rating position-relative">
                            <div class="rating-upper d-flex ">
                                <i class="bi bi-star-fill text-black-50"></i>
                                <i class="bi bi-star-fill text-black-50"></i>
                                <i class="bi bi-star-fill text-black-50"></i>
                                <i class="bi bi-star-fill text-black-50"></i>
                                <i class="bi bi-star-fill text-black-50"></i>
                            </div>
                            <div class="rating-lower d-flex  position-absolute top-0 start-0 overflow-hidden  w-${HealthyRecipe.ratePercentage}">
                                <i class="bi bi-star-fill text-warning"></i>
                                <i class="bi bi-star-fill text-warning"></i>
                                <i class="bi bi-star-fill text-warning"></i>
                                <i class="bi bi-star-fill text-warning"></i>
                                <i class="bi bi-star-fill text-warning"></i>
                            </div>
                        </div>
                    </div>
                    <div>
                        <p class="m-0">
                                ${(HealthyRecipe.ratePercentage)}
                        </p>
                    </div>
                </div>
                <div class="d-flex">
                    <i class="bi bi-alarm mx-1"></i>
                    <p class="m-0">
                            <span> ${(HealthyRecipe.prepTime)}</span>
                        دقيقة
                    </p>
                </div>
                <div class="d-flex">
                    <i class="bi bi-cup-hot mx-1"></i>
                    <p class="m-0">متوسط</p>
                </div>
            </div>
        </div>
    </div>
</div>
</a>
`;

    HealthyRecipeContainer.appendChild(card);
}
function RenderSkeletonCards() {
    HealthyRecipeContainer.innerHTML = "";
    for (var i = 0; i < 9; i++) {
        let card = document.createElement("div");
        card.className = "col placeholder-wave p-3";
        card.innerHTML = `<div class="card rounded-0 shadow-sm">
                                <div class="position-relative placeholder overflow-hidden image-box" style="height:300px"></div>
                                <div class="card-body p-0">
                                    <div class="d-flex justify-content-between align-items-center  p-2 title-box">
                                        <h6 class="card-title text-black fw-bold placeholder w-50  m-0">
                                        </h6>
                                    </div>
                                    <div class="d-flex  justify-content-between g-0  p-2">
                                        <div class="d-flex  w-25 d-flex placeholder"></div>
                                        <div class="d-flex  w-25 d-flex placeholder"></div>
                                        <div class="d-flex  w-25 d-flex placeholder"></div>
                                    </div>
                                </div>
                            </div>
                              `;
        HealthyRecipeContainer.appendChild(card);
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




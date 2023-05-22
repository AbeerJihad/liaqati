﻿var lstMealType = [];
var lstDietaryType = [];
var lstProgramlength = [];
let lstMealPlans = [];
var sortedByValue = document.getElementById("SortBy");
var SearchTearmValue = document.getElementById("SearchTearm");
let MealPlansContainer = document.querySelector("#mealPlan");
let Paging = document.querySelector("#Paging");
let formSearch = document.querySelector("#formSearch");
let searchTearmInput = document.querySelector("#searchTearm");
let NoResult = document.querySelector("#NoResult");
var searchTearm = "";
let SortOrder = "";
let Sortby = "";
let CurPage = 1;



async function getdata(categoryid) {

    RenderSkeletonCards();
    var parms = {
        curPage: CurPage,
        size: 12,
        sortBy: Sortby,
        sortOrder: SortOrder,
        Length: lstProgramlength,
        MealType: lstMealType,
        DietaryType: lstDietaryType,
        SearchTearm: searchTearm,
        title: '',
        userId: '',
        categoryid: '',
        maxPrice: null,
        minprice: null
    };
    console.log(parms)
    if (navigator.onLine) {
        lstMealPlans = await getMealPlans(parms);
        MealPlansContainer.innerHTML = "";
        if (lstMealPlans.listOfData && lstMealPlans.listOfData.length > 0) {
            NoResult.innerHTML = "";
            lstMealPlans.listOfData.forEach((p) => RenderCards(p));
        } else {
            RenderNoResult()
        }
        //lstMealPlans.listOfData.forEach((p) => RenderCards(p));
        RenderPagination(lstMealPlans);
        RenderCounters(lstMealPlans);
        console.log(lstMealPlans);
    } else {
        MealPlansContainer.innerHTML = "";

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
getdata(null);
lstSort.addEventListener('change', () => {
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

formSearch.addEventListener("submit", (e) => {
    e.preventDefault();
    CurPage = 1;
    searchTearm = searchTearmInput.value;
    getdata(null);
})

function getAll() {
    CurPage = 1;
    searchTearm = "";
    getdata(null);

}

window.addEventListener('online', () => {
    getAll()
})
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
window.addEventListener('offline', () => {
    MealPlansContainer.innerHTML = "";
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
function RenderCards(MealPlan) {


    var btn2 = ``;





    if (MealPlan.isFavorite == 2) {

        btn2 = ` <button title="add to Favorite" onclick="AddFavoriteMealPlan('${MealPlan.id}')" class="pt-0 rounded-pill btn-favorite text-secondary btn   bg-white  rounded d-flex fw-bold justify-content-center align-items-center align-middle">
                    <img width="25" height="25" src="/Images/heart-solid-24.png" />

                </button>`;


    }
    else {
        btn2 = `  <button title="add to Favorite" onclick="AddFavoriteMealPlan('${MealPlan.id}')" class="pt-0 rounded-pill btn-favorite text-secondary btn   bg-white  rounded d-flex fw-bold justify-content-center align-items-center align-middle">
                    <i class="bi bi-heart-fill h4 d-block m-0 mt-1"></i>

                </button>`;
    }





    const formatter = new Intl.NumberFormat('en-US', {
        style: 'currency', currency: 'USD',
        minimumFractionDigits: 2
    })

    let card = document.createElement("div");
    card.className = "col-12 col-md-6 col-lg-4 p-3";
    card.innerHTML = `<div class="card  shadow-sm meal-plan overflow-hidden">
            <div class="card-header bg-transparent">
                <p class="text-center  p-0 m-0">#${MealPlan.categoryName}</p>
            </div>
            <div class="position-relative  hoverable-image" style="height: 200px">
                <img src="${MealPlan.image}" class=" w-100 position-absolute h-100 top-0 start-0 object-fit-cover" alt="...">
                <div class="overlay w-100 position-absolute h-100 top-0 start-0"></div>
                <div class="position-absolute d-flex justify-content-center align-items-center w-100 h-100 p-3 top-0 start-0">
                    <a href="/MealPlan/MealPlanDetails?id=${MealPlan.id}" class="btn bg-white-with-transparent more-details-btn rounded-pill shadow border-0 p-2 px-3 fw-bold" type="button">
                        مزيد من التفاصيل
                    </a>
                </div>  
            </div>
            <div class="card-body">
                         <div class="d-flex justify-content-between"> 
                          <h6 class="card-title fw-bold text-black ">${MealPlan.title}</h6>
                            ${btn2}
                         </div>

                <div class="d-flex justify-content-between align-items-center">
                    <p class="card-subtitle">
                                    ${MealPlan.shortDescription}       
                      </p>
                    <p class="text-danger text-start h3 fw-bold me-3">${formatter.format(MealPlan.price)}</p>
                </div>

                <div class="d-flex justify-content-between align-items-center mt-2">
                    <div>
                        <p class="m-0">عدد الأسابيع ${MealPlan.length}   </p>
                    </div>
                    <div>
                        <button class="btn border-0 text-white" style="background-color: #cb8cef">
                            اشترك الان
                        </button>
                    </div>
                </div>
            </div>
         </div>
        </div>`;
    MealPlansContainer.appendChild(card);
}

function RenderSkeletonCards() {
    MealPlansContainer.innerHTML = "";
    for (var i = 0; i < 9; i++) {
        let card = document.createElement("div");
        card.className = "col-12 placeholder-wave col-md-6 col-lg-4 p-3";
        card.innerHTML = ` 
            <div class="card  shadow-sm meal-plan overflow-hidden">
              <div class="card-header  justify-content-center d-flex justify-content-center bg-transparent">
                <p class="text-center placeholder  p-0 m-0"># الأنظمة الحديثة</p>
              </div>

              <div class="position-relative  placeholder  hoverable-image" style="height: 200px"></div>

              <div class="card-body">
                <h5 class="card-title placeholder fw-bold text-black text-end">
                  النظام الغذائي الباليو
                </h5>
                <div class="d-flex justify-content-between align-items-center">
                  <p class="card-subtitle placeholder">
                    يعتمد على تقليل الكربوهيدرات ومنع السكر المصنع والبطاطا
                  </p>
                  <p class="text-danger text-start h3 fw-bold me-3 placeholder">$19.9</p>
                </div>

                <div class="d-flex justify-content-between align-items-center mt-2">
                  <div>
                    <p class="m-0 placeholder">أسبوع</p>
                  </div>
                  <div>
                    <button class="placeholder disabled  d-block btn border-0 text-white " style="background-color: #cb8cef; width:100px;">
                    </button>
                  </div>
                </div>
              </div>
            </div>


              </div>`;
        MealPlansContainer.appendChild(card);
    }
}

function NextPage(JsonData) {
    //alert(CurPage);
    //alert(JsonData);
    //alert(CurPage > JsonData.totalPages);
    if (CurPage < JsonData.totalPages) {
        CurPage++;
        getdata(null);
        //    alert(CurPage);
    }
}

function PrevPage() {
    if (CurPage > 1) {
        CurPage--;
        getdata(null);
        //alert(CurPage);

    }
}

function GetPage(index) {
    CurPage = parseInt(index);
    //alert(CurPage);

    getdata(null);
}

var MealTypeCheckboxes = document.getElementsByName("MealType");
MealTypeCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        CurPage = 1;

        lstMealType = renderList(MealTypeCheckboxes);
        getdata(null);
    });
});
var ProgramlengthCheckboxes = document.getElementsByName("programlength");
ProgramlengthCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        CurPage = 1;

        lstProgramlength = renderList(ProgramlengthCheckboxes);
        getdata(null);
    });
});
var DietaryTypeCheckboxes = document.getElementsByName("DietaryType");
DietaryTypeCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        CurPage = 1;

        lstDietaryType = renderList(DietaryTypeCheckboxes);
        getdata(null);
    });
});
function renderList(checkboxesSelector) {
    let checkedList = [];
    for (var checkbox of checkboxesSelector) {
        if (checkbox.checked) { checkedList.push(checkbox.value) };
    }
    return checkedList;
}
function RenderCounters(JsonData) {
    console.log(JsonData)
    var labels = document.getElementsByTagName('LABEL');
    var mealtype = [];
    var dietarytype = [];
    var ProgramLength = [];
    for (var i = 0; i < labels.length; i++) {
        if (labels[i].htmlFor != '') {
            if (labels[i].htmlFor.startsWith('MealType')) {
                mealtype.push(labels[i]);
            }
            else if (labels[i].htmlFor.startsWith('DietaryType')) {
                dietarytype.push(labels[i]);
            } else if (labels[i].htmlFor.startsWith('programlength')) {
                ProgramLength.push(labels[i]);
            }
        }
    }
    for (var i = 0; i < mealtype.length; i++) {
        if (JsonData.mealTypeCounters[i] === 0) {
            mealtype[i].control.disabled = true;
        }
        else {
            mealtype[i].control.disabled = false;
        }
        mealtype[i].lastElementChild.innerHTML = `(${JsonData.mealTypeCounters[i]})`;
    }
    for (var i = 0; i < dietarytype.length; i++) {
        if (JsonData.dietaryTypeCounters[i] === 0) {
            dietarytype[i].control.disabled = true;
        }
        else {
            dietarytype[i].control.disabled = false;
        }
        dietarytype[i].lastElementChild.innerHTML = `(${JsonData.dietaryTypeCounters[i]})`;
    }
    for (var i = 0; i < ProgramLength.length; i++) {
        if (JsonData.programLengthCounters[i] === 0) {
            ProgramLength[i].control.disabled = true;
        }
        else {
            ProgramLength[i].control.disabled = false;

        }
        ProgramLength[i].lastElementChild.innerHTML = `(${JsonData.programLengthCounters[i]})`;
    }
}
async function AddFavoriteMealPlan(id) {
    var IsAdd = await AddFavoritesToMealPlan(id);
    if (IsAdd = "true") {
        getdata(null);
    }
    else if (IsAdd = "false") {
        getdata(null);
    }
    else {
        window.location = "";
    }


}
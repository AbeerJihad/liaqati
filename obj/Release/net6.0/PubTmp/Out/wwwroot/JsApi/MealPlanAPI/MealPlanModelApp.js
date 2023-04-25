
let lstMealPlans = [];
let MealPlansContainer = document.querySelector("#mealPlan");
let Paging = document.querySelector("#Paging");
let CurPage = 1;
async function getdata(categoryid) {
    RenderSkeletonCards();
    lstMealPlans = await getMealPlans(categoryid, CurPage);
    MealPlansContainer.innerHTML = "";
    lstMealPlans.listOfData.forEach((p) => RenderCards(p));
    RenderPagination(lstMealPlans);
    console.log(lstMealPlans);

}
//RenderSkeletonCards();
getdata(null);

function RenderCards(MealPlan) {
    const formatter = new Intl.NumberFormat('en-US', {
        style: 'currency', currency: 'USD',
        minimumFractionDigits: 2
    })

    let card = document.createElement("div");
    card.className = "col-12 col-md-6 col-lg-4 p-3";
    card.innerHTML = `<div class="card  shadow-sm meal-plan overflow-hidden">
        <div class="card-header bg-transparent">
            <p class="text-center  p-0 m-0">#${MealPlan.services.category.name}</p>
        </div>
        <div class="position-relative  hoverable-image" style="height: 200px">
            <img src="${MealPlan.image}" class=" w-100 position-absolute h-100 top-0 start-0 object-fit-cover" alt="...">
            <div class="overlay w-100 position-absolute h-100 top-0 start-0"></div>
            <div class="position-absolute d-flex justify-content-center align-items-center w-100 h-100 p-3 top-0 start-0">
                <button class="btn bg-white-with-transparent more-details-btn rounded-pill shadow border-0 p-2 px-3 fw-bold" type="button">
                    مزيد من التفاصيل
                </button>
            </div>
        </div>
        <div class="card-body">
            <h5 class="card-title fw-bold text-black ">${MealPlan.services.title}</h5>
            <div class="d-flex justify-content-between align-items-center">
                <p class="card-subtitle">
                                ${MealPlan.services.shortDescription}       
                  </p>
                <p class="text-danger text-start h3 fw-bold me-3">${formatter.format(MealPlan.services.price)}</p>
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

function RenderPagination(JsonData) {

    Paging.firstElementChild.innerHTML = "";
    let perv = JsonData.previousPage === null ? "disabled" : "";
    let next = JsonData.nextPage === null ? "disabled" : "";
    console.log(JsonData.previousPage !== null ? "" : "disabled");
    var first = (CurPage != 1 && JsonData.totalPages != 0) ? "" : "disabled";
    var last = (CurPage != JsonData.totalPages && JsonData.totalPages != 0) ? "" : "disabled";
    console.log(perv)
    console.log(JsonData.previousPage !== null)
    console.log(JsonData.previousPage)

    var firstIndex = Math.max(CurPage - 2, 1);
    var lastIndex = Math.min(CurPage + 2, JsonData.totalPages);


    //alert(firstIndex)
    //alert(CurPage)
    //alert(lastIndex)
    let nav = document.createElement("nav");
    nav.setAttribute('aria-label', "Page navigation example")
    let ul = document.createElement("ul");
    ul.className = "pagination";
    nav.appendChild(ul);

    let liFirst = document.createElement("li");
    liFirst.className = "page-item";
    let aFirst = document.createElement("a");
    aFirst.className = "page-link first " + first;
    aFirst.setAttribute('aria-label', "First");
    aFirst.addEventListener("click", () => { CurPage = 1; getdata(null); });
    aFirst.innerHTML = `</i><i class="bi bi-arrow-bar-left"></i>`;
    liFirst.appendChild(aFirst);


    let liLast = document.createElement("li");
    liLast.className = "page-item";
    let aLast = document.createElement("a");
    aLast.className = "page-link " + last;
    aLast.setAttribute('aria-label', "Last");
    aLast.addEventListener("click", () => { CurPage = JsonData.totalPages; getdata(null); });
    aLast.innerHTML = `</i><i class="bi bi-arrow-bar-right"></i>`;
    liLast.appendChild(aLast);



    let liPer = document.createElement("li");
    liPer.className = "page-item";
    let aPer = document.createElement("a");
    aPer.className = "page-link " + perv;
    aPer.setAttribute('aria-label', "Previous");
    aPer.addEventListener("click", () => { PrevPage(JsonData); });
    aPer.innerHTML = `</i><i class="bi bi-arrow-left"></i>`;
    liPer.appendChild(aPer);
    //    <li class="page-item"><a class="page-link active" href="#">1</a></li>

    let liNext = document.createElement("li");
    liNext.className = "page-item";
    let aNext = document.createElement("a");
    aNext.className = "page-link " + next;
    aNext.setAttribute('aria-label', "Next");
    aNext.addEventListener("click", () => { NextPage(JsonData); });
    aNext.innerHTML = `</i><i class="bi bi-arrow-right"></i>`;
    liNext.appendChild(aNext);
    let listOfLi = [];
    for (var i = firstIndex; i <= lastIndex; i++) {
        let li = document.createElement("li");
        li.className = "page-item";
        let a = document.createElement("a");
        if (i == CurPage) { a.className = "page-link active"; }
        else {

            a.className = "page-link";
            a.setAttribute("data-page", i);
            a.addEventListener("click", () => { GetPage(a.getAttribute("data-page")) });

        }
        a.setAttribute('aria-label', "Previous");
        a.innerHTML = i;
        li.appendChild(a);
        listOfLi.push(li);
    }
    ul.appendChild(liLast);
    ul.appendChild(liNext);

    listOfLi = listOfLi.reverse();
    listOfLi.map(li => ul.appendChild(li))

    ul.appendChild(liPer);

    ul.appendChild(liFirst);
    Paging.firstElementChild.appendChild(nav);
}
//    CurPage = (CurPage !== JsonData.totalPages && JsonData.totalPages !== 0) ? CurPage++;

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

/*
@{
var perv = Model.queryPageResult.PreviousPage.HasValue ? "" : "disabled";
var next = Model.queryPageResult.NextPage.HasValue ? "" : "disabled";
var first = (Model.Parameters.CurPage != 1 && Model.queryPageResult.TotalPages != 0) ? "" : "disabled";
var last = (Model.Parameters.CurPage != Model.queryPageResult.TotalPages && Model.queryPageResult.TotalPages != 0) ? "" : "disabled";
var firstIndex = Math.Max(Model.Parameters.CurPage - 1, 1);
var lastIndex = Math.Min(Model.Parameters.CurPage + 1, Model.queryPageResult.TotalPages);
}
<nav aria-label="Page navigation example ">
<ul class="pagination  justify-content-end px-5">
    @{
        parms["CurPage"] = Model.queryPageResult.PreviousPage.ToString() ?? "";
    }
    <li class="page-item"><a class="page-link @perv" asp-all-route-data="parms">الصفحة السابقة</a></li>

    @for (int i = firstIndex; i <= lastIndex; i++)
    {
        parms["CurPage"] = i.ToString();
        string a = Model.Parameters.CurPage == i ? "active" : "";
        <li class="page-item"><a class="page-link @a" asp-all-route-data="parms">@i</a></li>
    }
    @{
        parms["CurPage"] = Model.queryPageResult.NextPage.ToString() ?? "";
    }
    <li class="page-item"><a class="page-link @next" asp-all-route-data="parms">الصفحة التالية</a></li>
</ul>
</nav>*/


//var multiBodyFoucs;
var lstBodyfocus = [];
var lsttraningtype = [];
var lstdifficalty = [];
var lstEquipment = [];
var MinDuration;
var MaxDuration;
var MinCalorieBurn;
var MaxCalorieBurn;
var txtsortBy;
var txtsearchTerm;
var CurPage = 1;
var sortedByValue = document.getElementById("SortBy");
var SearchTearmValue = document.getElementById("SearchTearm");


function RenderRow(container, { bodyFocus, burnEstimate, detail, difficulty, duration, equipments, id, image, price, shortDescription, title, traningType, video }) {

    let row = document.createElement('div');
    row.className = 'col-sm-6 col-lg-3 p-4 ';
    row.innerHTML = `
    <a href="Exercises/ExercisesDetiles/${id}">
               <div class="card border-0 h-100 ">
            <div class="position-relative">
                <img id="imgCard " src="${image}" style="width:100%;" />
                <img width="40" class="position-absolute"
                    style="top: 20px; right: 20px" src="./Images/Exercise/heart-svgrepo-com (1).png"
                    alt=""
                    srcset="" />
                <img width="70"
                    class="position-absolute"
                    style="bottom: 20px; right: 20px"
                    src="./Images/Exercise/ic_play_circle_outline_24px.png"
                    alt=""
                    srcset="" />
            </div>

            <div class="card-body">
                <p class="card-text  Exercises_duration_Color fw-bold">
                   ${duration} دقيقة/اليوم
                </p>
                <h6 class="card-title mb-3"> ${title}   </h6>
                <div class="">
                     <div class="rating-section">
                    <i class="bi bi-star-fill text-warning star"></i>
                    <i class="bi bi-star-fill text-warning star"></i>
                    <i class="bi bi-star-fill text-warning star"></i>
                    <i class="bi bi-star-fill text-secondary star"></i>
                    <i class="bi bi-star-fill text-secondary star"></i>
                </div>
                    <div class="d-flex justify-content-between mt-2">
                        <div>
                            <h4 class="d-inline-block text-danger align-middle">
                                    <span>  ${(price == 0 ? 'مجانا' : "${price} $")} </span>
                     

                            </h4>
                        </div>
                        <div>
                            <button class="btn_Exercises_duration col-auto text-white rounded-3 fw-bold d-inline-block border-0 py-1 px-2">
                                ابدا الان

                                <img src="/images/Exercise/cart.png" />

                            </button>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        </a>
`;


    container.appendChild(row);
}

function RenderSkeletonCards(container) {

    for (var i = 0; i < 9; i++) {
        let row = document.createElement('div');
        row.className = 'col-sm-6 placeholder-wave col-lg-3 p-4 ';
        row.innerHTML = `
               <div class="card border-0 h-100 ">
          <div class="position-relative  placeholder  hoverable-image" style="height: 200px"></div>
                

            <div class="card-body">
                <p class="card-text placeholder Exercises_duration_Color fw-bold w-100">
                </p>
                <h6 class="card-title mb-3 w-100 placeholder"></h6>
                <div class="">
                     <div class="rating-section text-warning placeholder" >
                    <i class="bi bi-star-fill text-warning star"></i>
                    <i class="bi bi-star-fill text-warning star"></i>
                    <i class="bi bi-star-fill text-warning star"></i>
                    <i class="bi bi-star-fill text-warning star"></i>
                    <i class="bi bi-star-fill text-warning star"></i>
                </div>
                    <div class="d-flex justify-content-between mt-2">
                        <div>
                            <h4 class="d-inline-block placeholder text-danger align-middle placeholder w-100">
                     

                            </h4>
                        </div>
                        <div class="col-6">
                            <a class="btn_Exercises_duration h-100 w-100 col-auto text-white rounded-3 placeholder fw-bold d-inline-block border-0 py-1 px-2">


                            </a>
                        </div>

                    </div>
                </div>
            </div>
        </div>
`;
        document.getElementById(container).appendChild(row);
    }

}

async function postData(url = "", data = {}) {
    const response = await fetch(url, {
        method: "POST",
        mode: "cors",
        cache: "no-cache",
        credentials: "same-origin",
        headers: { "Content-Type": "application/json" },
        redirect: "follow",
        referrerPolicy: "no-referrer",
        body: JSON.stringify(data)
    });
    return response.json();
}


GetAll()


var bodyfocusCheckboxes = document.getElementsByName("bodyfocus");
bodyfocusCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        lstBodyfocus = renderList(bodyfocusCheckboxes);
        GetAll();
    });
});
var traningtypeCheckboxes = document.getElementsByName("traningtype");
traningtypeCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        lsttraningtype = renderList(traningtypeCheckboxes);
        GetAll();
    });
});
var difficultyCheckboxes = document.getElementsByName("difficulty");
difficultyCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        lstdifficalty = renderList(difficultyCheckboxes);
        GetAll();
    });
});
var equipmentCheckboxes = document.getElementsByName("equipment");
equipmentCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        lstEquipment = renderList(equipmentCheckboxes);
        GetAll();
    });
});
function renderList(checkboxesSelector) {
    let checkedList = [];
    for (var checkbox of checkboxesSelector) {
        if (checkbox.checked) { checkedList.push(checkbox.value) };
    }
    return checkedList;
}

/*var MinDuration;
var MaxDuration;
var MinCalorieBurn;
var MaxCalorieBurn;*/

function MinCalorieBurnChange() {
    var x = document.getElementById("MinCalorieBurn");
    console.log(x.value);
    if (x.value.length > 0) {
        MinCalorieBurn = x.value;
    } else {
        MinCalorieBurn = null;
    }
    GetAll();
}

function MaxCalorieBurnChange() {
    var x = document.getElementById("MaxCalorieBurn");
    console.log(`x ${x.value}`);
    if (x.value.length > 0) {
        MaxCalorieBurn = x.value;
    } else {
        MaxCalorieBurn = null;
    }
    GetAll();
}
function MinDurationChange() {
    var x = document.getElementById("Minduration");
    console.log(x.value);
    if (x.value.length > 0) {
        MinDuration = x.value;
    } else {
        MinDuration = null;
    }
    GetAll();
}

function MaxDurationChange() {
    var x = document.getElementById("Maxduration");
    console.log(`x ${x.value}`);
    if (x.value.length > 0) {
        MaxDuration = x.value;
    } else {
        MaxDuration = null;
    }
    GetAll();
}
/*{
  "curPage": 0,
  "size": 0,
  "sortBy": "string",
  "sortOrder": "string",
  "bodyFocus": [
    "string"
  ],
  "traningType": [
    "string"
  ],
  "difficulty": [
    0
  ],
  "equipment": [
    "string"
  ],
  "minDuration": 0,
  "maxDuration": 0,
  "searchTearm": "string",
  "title": "string"
}*/
function GetAll() {
    RenderSkeletonCards('rowExercisesIndex');
    var parms = {
        bodyFocus: lstBodyfocus,
        traningType: lsttraningtype,
        difficulty: lstdifficalty,
        equipment: lstEquipment,
        MinDuration: MinDuration,
        MaxDuration: MaxDuration,
        SortBy: txtsortBy,
        SearchTearm: txtsearchTerm,
        CurPage: CurPage,
        Size: 12,
    };
    console.table(parms);
    postData("https://localhost:7232/api/ExerciseApi/searchforExercise", parms).then((data) => {
        console.log(data);
        document.getElementById("rowExercisesIndex").innerHTML = ""
        data.listOfData.forEach(p => {
            RenderRow(document.getElementById("rowExercisesIndex"), p);
        });

        RenderPagination(data)
        RenderCounters(data)

        console.log(data);


    }).catch((er) => {
        console.error(er);
    });
}

function sortFun() {
    txtsortBy = sortedByValue.value;
    GetAll();
}

function SearchFun() {
    txtsearchTerm = SearchTearmValue.value;
    GetAll();
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
    aFirst.addEventListener("click", () => {
        CurPage = 1;
        GetAll()

    });
    aFirst.innerHTML = `</i><i class="bi bi-arrow-bar-left"></i>`;
    liFirst.appendChild(aFirst);


    let liLast = document.createElement("li");
    liLast.className = "page-item";
    let aLast = document.createElement("a");
    aLast.className = "page-link " + last;
    aLast.setAttribute('aria-label', "Last");
    aLast.addEventListener("click", () => {
        CurPage = JsonData.totalPages; GetAll();
    });
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

function NextPage(JsonData) {
    if (CurPage < JsonData.totalPages) {
        CurPage++;
        GetAll()
    }
}

function PrevPage() {
    if (CurPage > 1) {
        CurPage--;
        GetAll()
    }
}

function GetPage(index) {
    CurPage = parseInt(index);
    GetAll()
}


/*{bodyfocusCounters: Array(4), traningTypeCounters: Array(15), difficultyCounters: Array(5), equipmentCounters: Array(13), totalCount: 10, …}
*/
function RenderCounters(JsonData) {
    console.log(JsonData)

    var labels = document.getElementsByTagName('LABEL');
    var BodyFoucs = [];
    var TraningType = [];
    var Equipment = [];
    var Difficulty = [];
    for (var i = 0; i < labels.length; i++) {
        if (labels[i].htmlFor != '') {
            if (labels[i].htmlFor.startsWith('BodyFoucs')) {
                BodyFoucs.push(labels[i]);
            }
            else if (labels[i].htmlFor.startsWith('TraningType')) {
                TraningType.push(labels[i]);


            } else if (labels[i].htmlFor.startsWith('Equipment')) {
                Equipment.push(labels[i]);
            } else if (labels[i].htmlFor.startsWith('Difficulty')) {
                Difficulty.push(labels[i]);

            }
        }
    }

    for (var i = 0; i < BodyFoucs.length; i++) {
        if (JsonData.bodyfocusCounters[i] === 0) {
            BodyFoucs[i].control.disabled = true;
        }
        else {
            BodyFoucs[i].control.disabled = false;
        }
        BodyFoucs[i].lastElementChild.innerHTML = `(${JsonData.bodyfocusCounters[i]})`;
    }
    for (var i = 0; i < Equipment.length; i++) {
        if (JsonData.equipmentCounters[i] === 0) {
            Equipment[i].control.disabled = true;
        }
        else {
            Equipment[i].control.disabled = false;
        }
        Equipment[i].lastElementChild.innerHTML = `(${JsonData.equipmentCounters[i]})`;
    }
    for (var i = 0; i < TraningType.length; i++) {
        if (JsonData.traningTypeCounters[i] === 0) {
            TraningType[i].control.disabled = true;
        }
        else {
            TraningType[i].control.disabled = false;

        }
        TraningType[i].lastElementChild.innerHTML = `(${JsonData.traningTypeCounters[i]})`;
    }
    for (var i = 0; i < Difficulty.length; i++) {
        if (JsonData.difficultyCounters[i] === 0) {
            Difficulty[i].control.disabled = true;
        }
        else {
            Difficulty[i].control.disabled = false;
        }
        Difficulty[i].lastElementChild.innerHTML = `(${JsonData.difficultyCounters[i]})`;
    }

}
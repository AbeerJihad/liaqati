

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
let formSearch = document.querySelector("#formSearch");
var sortedByValue = document.getElementById("SortBy");
var SearchTearmValue = document.getElementById("searchTearm");
let lstSort = document.querySelector("#lstSort");
let NoResult = document.querySelector("#NoResult");
let searchTearm = "";
let SortOrder = "";
let Sortby = "";
function ShowAll() {
    lstBodyfocus = [];
    lsttraningtype = [];
    lstdifficalty = [];
    lstEquipment = [];
    MinDuration = null;
    MaxDuration = null;;
    MinCalorieBurn = null;;
    MaxCalorieBurn = null;;
    txtsortBy = "";
    searchTearm = "";
    CurPage = 1;
    GetAll()
}
function RenderRow(container, { ratePercentage, bodyFocus, burnEstimate, detail, difficulty, duration, equipments, id, image, price, shortDescription, title, traningType, video, isFavorite }) {


    var btn2 = ``;
    var rate = ``;





    if (isFavorite == 2) {

        btn2 = ` <button title="add to Favorite" onclick="AddFavoriteExercises('${id}')" class="pt-0 rounded-pill btn-favorite text-secondary btn   bg-white  rounded d-flex fw-bold justify-content-center align-items-center align-middle">
                    <img width="25" height="25" src="/Images/heart-solid-24.png" />

                </button>`;


    }
    else {
        btn2 = `  <button title="add to Favorite" onclick="AddFavoriteExercises('${id}')" class="pt-0 rounded-pill btn-favorite text-secondary btn   bg-white  rounded d-flex fw-bold justify-content-center align-items-center align-middle">
                    <i class="bi bi-heart-fill h4 d-block m-0 mt-1"></i>

                </button>`;
    }




    if (ratePercentage == null) {

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





    let row = document.createElement('div');
    row.className = 'col-sm-6 col-lg-3 p-4 ';

    row.innerHTML = `   
       <div class="card border-0 h-100 ">
          <div class="position-relative">
             <img id="imgCard " src="${image}" height="220" style="width:100%;" />
              <img width="40" class="position-absolute"
                  style="top: 20px; right: 20px" src="./Images/Exercise/heart-svgrepo-com (1).png"
                   alt="" srcset="" />
               <img width="70"
                    class="position-absolute"
                    style="bottom: 20px; right: 20px"
                    src="./Images/Exercise/ic_play_circle_outline_24px.png"
                    alt="" srcset="" />
         </div>

         <div class="card-body d-flex flex-column justify-content-between">
            <h5 class="card-title  text-dark mb-3"> ${title}   </h5>

        <div class=" d-flex my-1 justify-content-between">
            <p class="card-text  Exercises_duration_Color fw-bold" style="color: #A566C8;">
                   ${duration} دقيقة/اليوم   
             </p>      
                ${rate}
         </div>               </div>
  
               <div class=" d-flex justify-content-between">    

                  <a href="Exercises/ExercisesDetiles/${id}" class="btn_Exercises_duration col-auto  text-white rounded-3 fw-bold d-inline-block border-0 px-4 py-2 "  style="background-color: #BE8ADC;">
                               ابدأ الان
                     <img class="mx-1" src="/images/Exercise/cart.png" />
                    </a>      
     ${btn2}
               </div>
            </div>
         </div>
  
`

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
    GetAll();
})
formSearch.addEventListener("submit", (e) => {
    e.preventDefault();
    searchTearm = SearchTearmValue.value;
    GetAll();
})
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
    document.getElementById("rowExercisesIndex").innerHTML = "";
    RenderSkeletonCards('rowExercisesIndex');
    var parms = {
        bodyFocus: lstBodyfocus,
        traningType: lsttraningtype,
        difficulty: lstdifficalty,
        equipment: lstEquipment,
        MinDuration: MinDuration,
        MaxDuration: MaxDuration,
        SortBy: txtsortBy,
        SearchTearm: searchTearm,
        CurPage: CurPage,
        Size: 12,
    };
    console.table(parms);
    postData("/api/ExerciseApi/searchforExercise", parms).then((data) => {
        console.log(data);
        document.getElementById("rowExercisesIndex").innerHTML = ""
        if (data.listOfData && data.listOfData.length > 0) {
            data.listOfData.forEach(p => {
                RenderRow(document.getElementById("rowExercisesIndex"), p);
            });
        } else {
            RenderNoResult()
        }
        RenderPagination(data)
        RenderCounters(data)

        console.log(data);


    }).catch((er) => {
        console.error(er);
    });
}



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
            <div><a class="btn btn-primary" onclick="ShowAll()">عرض الكل</a></div>
          </div>
      </div>
                              `;
    document.getElementById("rowExercisesIndex").appendChild(card);

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



async function AddFavoriteExercises(id) {

    var IsAdd = await AddFavoritesToExercises(id);
    if (IsAdd == "true") {


        GetAll();

    }
    else if (IsAdd = "false") {

        GetAll();
    }
    else {
        window.location = "";
    }





}




async function AddFavoritesToExercises(id) {

    let result;
    try {
        const response = await fetch(`https://localhost:7232/api/ExerciseApi/AddFavoritesExercises/${id}`, {
            method: "GET",
        });
        if (response.status === 200) {
            result = await response.json();
        }
        else {
            console.error(json);
            //`Error: ${json.title}`;
        }
    } catch (err) {
        console.error(err);
    }

    return result;
}





var multiBodyFoucs;

async function GetByIDAsync(SelectExercises) {
    RenderSkeletonCards("rowExercisesIndex")
    let url = "https://localhost:7232/api/ExerciseApi/AllExercise";

    var xxx = document.getElementById(SelectExercises);

    let result = [];

    const response = await fetch(url, {
        method: "GET",
    }).
        then((response) => response.json())
        .then((data) => {
            xxx.innerHTML = "";
            data.forEach(p => RenderRow(xxx, p));
            console.log(data);
        })
        .catch((er) => {
            console.error(er);
        });
}

function RenderRow(container, { bodyFocus, burnEstimate, detail, difficulty, duration, equipments, id, image, price, shortDescription, title, traningType, video }) {

    let row = document.createElement('div');
    row.className = 'col-sm-6 col-lg-3 p-4 ';
    row.innerHTML = `
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
`;


    container.appendChild(row);
}

function RenderSkeletonCards(container) {
    var xxx = document.getElementById(container);

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
        xxx.appendChild(row);
    }

}

async function postData(url = "", data = {}) {


    const response = await fetch(url, {
        method: "POST",
        mode: "cors",
        cache: "no-cache",
        credentials: "same-origin",
        headers: {
            "Content-Type": "application/json",
        },
        redirect: "follow",
        referrerPolicy: "no-referrer",
        body: JSON.stringify(data)
    });

    return response.json();
}


GetByIDAsync("rowExercisesIndex");









var lstBodyfocus = [];
var lsttraningtype = [];
var lstdifficalty = [];
var lstEquipment = [];
var minDur;
var maxDur;
var txtsortBy;
var txtsearchTerm;

// for bodyfoucs
for (var op of form1.elements.g) {

    op.addEventListener('change', function (event) {
        if (event.target.checked) {
            console.log(event.target.value);
            lstBodyfocus.push(event.target.value);
            multiSelect();
        }
        else if (!event.target.checked) {
            lstBodyfocus.pop(event.target.value);
            multiSelect();
            console.log(lstBodyfocus);
        }
        console.log(lstBodyfocus);
    })
}

//for traning type
for (var op of form1.elements.traningtype) {

    op.addEventListener('change', function (event) {
        if (event.target.checked) {
            console.log(event.target.value);
            lsttraningtype.push(event.target.value);
            multiSelect();
        }

        else if (!event.target.checked) {
            lsttraningtype.pop(event.target.value);
            multiSelect();
            console.log(lsttraningtype);

        }
        console.log(lsttraningtype);
    })
}

//for difficalty
for (var op of form1.elements.difficulty) {

    op.addEventListener('change', function (event) {
        if (event.target.checked) {
            console.log(event.target.value);
            lstdifficalty.push(event.target.value);
            multiSelect();
        }

        else if (!event.target.checked) {
            lstdifficalty.pop(event.target.value);
            multiSelect();
            console.log(lstdifficalty);

        }
        console.log(lstdifficalty);
    })
}


for (var op of form1.elements.Equipment) {

    op.addEventListener('change', function (event) {
        if (event.target.checked) {
            console.log(event.target.value);
            lstEquipment.push(event.target.value);
            multiSelect();
        }

        else if (!event.target.checked) {
            lstEquipment.pop(event.target.value);
            multiSelect();
            console.log(lstEquipment);
        }
    })
}

//for min && max duration
function mindurFun() {
    //alert('here')
    var x = document.getElementById("Minduration");
    console.log(x.value);
    minDur = x.value;
    multiSelect();
}
function maxdurFun() {
    var x = document.getElementById("Maxduration");
    console.log(x.value);
    maxDur = x.value;
    multiSelect();
}
var sortedByValue = document.getElementById("SortBy");
var SearchTearmValue = document.getElementById("SearchTearm");

function multiSelect() {


    postData("https://localhost:7232/api/ExerciseApi/searchforExercise", {
        bodyFocus: lstBodyfocus,
        traningType: lsttraningtype,
        difficulty: lstdifficalty,
        equipment: lstEquipment,
        MinDuration: minDur,
        MaxDuration: maxDur,
        SortBy: txtsortBy,
        SearchTearm: txtsearchTerm


    }).then((data) => {
        console.log(data);

        document.getElementById("rowExercisesIndex").innerHTML = ""

        data.listOfData.forEach(p => {
            RenderRow(document.getElementById("rowExercisesIndex"), p);
        });

        console.log(data);


    }).catch((er) => {
        console.error(er);
    });
}

function sortFun() {
    txtsortBy = sortedByValue.value;
    multiSelect();
}

function SearchFun() {
    txtsearchTerm = SearchTearmValue.value;
    multiSelect();
}


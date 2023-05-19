var lstBodyfocus = [];
var lsttraningtype = [];
var lstdifficalty = [];
var lstEquipment = [];
var lstProgramlength = [];
var MinDuration;
var MaxDuration;
var MinCalorieBurn;
var MaxCalorieBurn;
var txtsortBy;
var txtsearchTerm;
var sortedByValue = document.getElementById("SortBy");
var SearchTearmValue = document.getElementById("SearchTearm");
let ProgramApiResult;
let ProgramContainer = document.querySelector("#ProgramContainer");
let Paging = document.querySelector("#Paging");
let CurPage = 1;

var Name;
var Spec;

function SearchExpertFun() {
    Name = document.getElementById("name").value;
    Spec = document.getElementById("selectSpecExpert").options[document.getElementById("selectSpecExpert").selectedIndex].value;
    getdata();

}


async function getdata() {
    RenderSkeletonCards();
    var parms = {
        CurPage: CurPage,
        size: 12,
        name: "",
        Specialization: "",
        bodyFocus: lstBodyfocus,
        traningType: lsttraningtype,
        difficulty: lstdifficalty,
        equipment: lstEquipment,
        MinDuration: MinDuration,
        MaxDuration: MaxDuration,
        SortBy: txtsortBy,
        SearchTearm: txtsearchTerm,
        length: lstProgramlength



    };

    ProgramApiResult = await getSportsProgram(parms);
    ProgramContainer.innerHTML = "";
    console.log(ProgramApiResult.listOfData);
    ProgramApiResult.listOfData.forEach((p) => RenderCards(p));
    RenderPagination(ProgramApiResult);
    RenderCounters(ProgramApiResult);
    console.log(ProgramApiResult);

}
//RenderSkeletonCards();
getdata();
/*calories
description
dietaryType
id
image
ingredients
mealType
meal_Healthy
prepTime
preparationMethod
price
protein
shortDescription
title6
total_Carbohydrate
*/
function RenderCards(Program) {

    const formatter = new Intl.NumberFormat('en-US', {
        style: 'currency', currency: 'USD',
        minimumFractionDigits: 2
    })


    var btn2 = ``;





    if (Program.isFavorite == 2) {

        btn2 = ` <button title="add to Favorite" onclick="AddFavoriteProgram('${Program.id}')" class="pt-0 rounded-pill btn-favorite text-secondary btn   bg-white  rounded d-flex fw-bold justify-content-center align-items-center align-middle">
                    <img width="25" height="25" src="/Images/heart-solid-24.png" />

                </button>`;


    }
    else {
        btn2 = `  <button title="add to Favorite" onclick="AddFavoriteProgram('${Program.id}')" class="pt-0 rounded-pill btn-favorite text-secondary btn   bg-white  rounded d-flex fw-bold justify-content-center align-items-center align-middle">
                    <i class="bi bi-heart-fill h4 d-block m-0 mt-1"></i>

                </button>`;
    }











    console.log(Program);
    let card = document.createElement("div");
    card.className = "col p-3";
    card.innerHTML = `
   <div class=" p-3">
    <div class="card h-100  shadow-sm meal-plan overflow-hidden">
        <div class="card-header bg-transparent">
            <p class="text-center  p-0 m-0"># الأنظمة الحديثة</p>
        </div>

        <div class="position-relative   hoverable-image" style="height: 200px">
            <img src="${Program.image}" class=" w-100 position-absolute h-100 top-0 start-0 object-fit-cover" alt="...">
            <div class="overlay w-100 position-absolute h-100 top-0 start-0"></div>
            <div class="position-absolute d-flex justify-content-center align-items-center w-100 h-100 p-3 top-0 start-0">
                <button class="btn bg-white-with-transparent more-details-btn rounded-pill shadow border-0 p-2 px-3 fw-bold" type="button">
                    مزيد من التفاصيل
                </button>
            </div>
        </div>

        <div class="card-body">
                  ${btn2}

            <h5 class="card-title fw-bold text-black text-end"> ${Program.title}
            </h5>
            <div class="d-flex justify-content-between align-items-center">
                <p class="card-subtitle">
                    يعتمد على تقليل الكربوهيدرات ومنع السكر المصنع والبطاطا
                </p>
                <p class="text-danger text-start h4 fw-bold me-3">${formatter.format(Program.services.price)}</p>
            </div>

            <div class="d-flex justify-content-between align-items-center mt-2">
                <div>
                    <p class="m-0"> ${Program.length} أسبوع </p>
                </div>
                <div>
                    <button class="btn border-0 text-white" style="background-color: #cb8cef">
                        اشترك الان
                    </button>
                </div>
            </div>
        </div>
    </div>
</div>

`;

    ProgramContainer.appendChild(card);
}

function RenderSkeletonCards() {
    ProgramContainer.innerHTML = "";
    for (var i = 0; i < 9; i++) {
        let card = document.createElement("div");
        card.className = "col placeholder-wave p-3";
        card.innerHTML = `  <div class=" placeholder-wave  p-3">
            <div class="card border-0 rounded-0 shadow">
                <div class="position-relative  placeholder  hoverable-image" style="height: 250px"></div>


                <div class="card-body p-2 px-3">
                    <div class="row justify-content-center align-items-center">
                        <div class="col-6">
                            <h6 class="card-title text-black placeholder w-100 text-end">أ. جواد احمد</h6>
                            <p class="card-subtitle placeholder text-black-50 fw-normal w-100">
                            </p>
                        </div>
                        <div class="col-6">
                            <div class="text-start">
                                <button title="BE8ADC" type="button"
                                    class="btn btn-main border-0 disabled text-white fw-bold px-3 placeholder w-100  "
                                    type="submit">
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
                              `;
        ProgramContainer.appendChild(card);
    }
}




var bodyfocusCheckboxes = document.getElementsByName("bodyfocus");
bodyfocusCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        lstBodyfocus = renderList(bodyfocusCheckboxes);
        getdata(null);
    });
});
var traningtypeCheckboxes = document.getElementsByName("traningtype");
traningtypeCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        lsttraningtype = renderList(traningtypeCheckboxes);
        getdata(null);
    });
});
var ProgramLengthCheckboxes = document.getElementsByName("programlength");
ProgramLengthCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        lstProgramlength = renderList(ProgramLengthCheckboxes);
        getdata(null);
    });
});
var difficultyCheckboxes = document.getElementsByName("difficulty");
difficultyCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        lstdifficalty = renderList(difficultyCheckboxes);
        getdata(null);
    });
});
var equipmentCheckboxes = document.getElementsByName("equipment");
equipmentCheckboxes.forEach((chBox) => {
    chBox.addEventListener("change", () => {
        lstEquipment = renderList(equipmentCheckboxes);
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
    getdata(null);
}

function MaxCalorieBurnChange() {
    var x = document.getElementById("MaxCalorieBurn");
    console.log(`x ${x.value}`);
    if (x.value.length > 0) {
        MaxCalorieBurn = x.value;
    } else {
        MaxCalorieBurn = null;
    }
    getdata(null);
}
function MinDurationChange() {
    var x = document.getElementById("Minduration");
    console.log(x.value);
    if (x.value.length > 0) {
        MinDuration = x.value;
    } else {
        MinDuration = null;
    }
    getdata(null);
}

function MaxDurationChange() {
    var x = document.getElementById("Maxduration");
    console.log(`x ${x.value}`);
    if (x.value.length > 0) {
        MaxDuration = x.value;
    } else {
        MaxDuration = null;
    }
    getdata(null);
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

function RenderCounters(JsonData) {
    console.log(JsonData)
    var labels = document.getElementsByTagName('LABEL');
    var BodyFoucs = [];
    var TraningType = [];
    var Equipment = [];
    var Difficulty = [];
    var ProgramLength = [];
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
            else if (labels[i].htmlFor.startsWith('programlength')) {
                ProgramLength.push(labels[i]);

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


async function AddFavoriteProgram(id) {
    var IsAdd = await AddFavoritesToProgram(id);
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

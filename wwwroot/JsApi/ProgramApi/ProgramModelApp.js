let ProgramApiResult;
let ProgramContainer = document.querySelector("#ProgramContainer");
let Paging = document.querySelector("#Paging");
let CurPage = 1;

var Name;
var Spec;

function SearchExpertFun()
{
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

    };

    ProgramApiResult = await getSportsProgram(parms);
    ProgramContainer.innerHTML = "";
    console.log(ProgramApiResult.listOfData);
    ProgramApiResult.listOfData.forEach((p) => RenderCards(p));
    RenderPagination(ProgramApiResult);
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
            <h5 class="card-title fw-bold text-black text-end"> ${Program.services.title}
            </h5>
            <div class="d-flex justify-content-between align-items-center">
                <p class="card-subtitle">
                    يعتمد على تقليل الكربوهيدرات ومنع السكر المصنع والبطاطا
                </p>
                <p class="text-danger text-start h3 fw-bold me-3">$ ${Program.services.price}</p>
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


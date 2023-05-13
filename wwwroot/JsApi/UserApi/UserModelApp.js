let ExpertsApiResult;
let ExpertsContainer = document.querySelector("#ExpertsContainer");
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
        name: Name,
        Specialization: Spec,
    };

    ExpertsApiResult = await getUsers(parms);
    ExpertsContainer.innerHTML = "";
    console.log(ExpertsApiResult.listOfData);
    ExpertsApiResult.listOfData.forEach((p) => RenderCards(p));
    RenderPagination(ExpertsApiResult);
    console.log(ExpertsApiResult);

}
//RenderSkeletonCards();
getdata();

function RenderCards(Expert) {
    console.log(Expert);
    let card = document.createElement("div");
    card.className = "col p-3";

    let social = "";


    if (Expert.instagram != null) {
        social += ` <a title="instagram" class="btn social-media-icon border-0 bg-transparentp-0 m-0" href="${Expert.instagram}">
                        <i class="bi bi-instagram h5 text-white"></i>
                    </a>`
    }
    if (Expert.twitter != null) {
        social += ` <a title="twitter" class="btn social-media-icon border-0 bg-transparent p-0 m-0" href="${Expert.twitter}">
                        <i class="bi bi-twitter h5 text-white"></i>
                    </a>`
    }
    if (Expert.whatsApp != null) {
        social += ` <a title="whatsapp" class="btn social-media-icon border-0 bg-transparent p-0 m-0" href="${Expert.whatsApp}">
                        <i class="bi bi-whatsapp h5 text-white"></i>
                    </a>`
    }

    card.innerHTML = `
    <div class="">
            <div class="card border-0 rounded-0 shadow">
                <div class="position-relative overflow-hidden" style="height: 250px">
                    <img src="${Expert.photo}" class="card-img-top object-fit-cover w-100 h-100" alt="..." />
                </div>
                <div class="position-absolute top-0 end-0 p-3">
                    ${social}
                </div>
                <div class="card-body p-2 px-3">
                    <div class="row justify-content-center align-items-center">
                        <div class="col-6">
                            <h6 class="card-title text-black ">${Expert.fullName}</h6>
                            <p class="card-subtitle text-black-50 fw-normal">
                             ${Expert.specialization}
                            </p>
                        </div>
                        <div class="col-6">
                            <div class="text-end">
                                <button class="btn btn-main border-0 text-white fw-bold px-3" type="submit">
                                    احجز موعد
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

`;

    ExpertsContainer.appendChild(card);
}

function RenderSkeletonCards() {
    ExpertsContainer.innerHTML = "";
    for (var i = 0; i < 9; i++) {
        let card = document.createElement("div");
        card.className = "col placeholder-wave p-3";
        card.innerHTML = `  <div class="card border-0 rounded-0 shadow">
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
            </div>`;
        ExpertsContainer.appendChild(card);
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




//var options = { searchable: false };
//NiceSelect.bind(document.getElementById("selectSpecExpert"), options);


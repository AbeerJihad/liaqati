let ConsultationApiResult;
let ConsultationContainer = document.querySelector("#ConsultationsContainer");
let Paging = document.querySelector("#Paging");
let CurPage = 1;
async function getdata(categoryid) {
    RenderSkeletonCards();
    var parms = {
        CurPage: CurPage,
        size: 6,
        dietaryType: [],
        mealType: [],

    };

    ConsultationApiResult = await getConsultations(parms);
   ConsultationContainer.innerHTML = "";
    ConsultationApiResult.listOfData.forEach((p) => RenderCards(p));
    RenderPagination(ConsultationApiResult);
    console.log(ConsultationApiResult);

}
//RenderSkeletonCards();
getdata(null);

function RenderCards(Consultation) {
    console.log(Consultation);
    let card = document.createElement("div");
    card.className = "col p-3";
    card.innerHTML = `
    <div class="card m-2">
                        <div class="card-body">
                        <div class="d-flex justify-content-between">
                            <div class="d-flex">
                                <p>الاسم:
                                <span>${Consultation.user?.fname}</span>

                                </p>
                              <p class="mx-2">العمر:  <span>${new Date().getFullYear() - new Date(Consultation.user?.birthdate).getFullYear()}</span> </p>
                                <p>${formarDate(Consultation.postDate)}</p>
                           </div>
                            <p> ${Consultation.category?.name}</p>
                         </div>
                            <h5 class="card-title">${Consultation.title}</h5>
                            <hr />
                            <div class="d-flex justify-content-between">
                                <div>
                                    <p>الاجابة عن الاستشارة</p>
                                </div>
                                <div><a href="/Consultations/Replyconsultation/${Consultation.id}">
                                    <button class="colorbg p-2 border-0 rounded-3 text-white">عرض الاجابة</button>
                                  </a>
                                </div>
                            </div>
                        </div>
                    </div>
`;

   ConsultationContainer.appendChild(card);
}



function RenderSkeletonCards() {
    ConsultationContainer.innerHTML = "";
    for (var i = 0; i < 9; i++) {
        let card = document.createElement("div");
        card.className = "col placeholder-wave p-3";
        card.innerHTML = ` <div class="card m-2">
                        <div class="card-body">
                            <div class="d-flex">
                                <p></p>
                                <p class="mx-2"></p>
                                <p></p>
                            </div>
                            <h5 class="card-title"></h5>
                            <hr />
                            <div class="d-flex justify-content-between">
                                <div>
                                    <p></p>
                                    <p class="txtcolor"> </p>
                                </div>
                                <div>
                                    <button class="colorbg p-2 border-0 rounded-3 text-white"></button>
                                </div>
                            </div>
                        </div>
                    </div>
                              `;
        ConsultationContainer.appendChild(card);
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

function  formarDate(dat) {
    var date = new Date(dat);
    var months = ["يناير", "فبراير", "مارس", "إبريل", "مايو", "يونيو",
        "يوليو", "أغسطس", "سبتمبر", "أكتوبر", "نوفمبر", "ديسمبر"
    ];

    var delDateString = months[date.getMonth()] + ' ' + date.getFullYear();
    return delDateString;
}



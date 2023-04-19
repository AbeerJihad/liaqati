
var exIds = [];
var bool = false;
var multiBodyFoucs;


async function getExercises(SelectExercises) {
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
               <div class="card border-0 h-100">
            <div class="position-relative">
                <img id="imgCard" src="./Images/Exercise/4be142b5-fac5-4371-bfce-3f2d1b4201e6.png" style="width:100%;" />
                <img width="40" class="position-absolute"style="top: 20px; right: 20px" src="/Images/Exercise/heart-svgrepo-com (1).png" alt="" srcset="" />
                <img width="70" class="position-absolute" style="bottom: 20px; right: 20px" src="/Images/Exercise/ic_play_circle_outline_24px.png" alt="" srcset="" />
            </div>

            <div class="card-body">
                <p class="card-text  Exercises_duration_Color fw-bold">
                    دقيقة اليوم[Time]-- أسابيع   8 برنامج
                </p>
                <h5 class="card-title  m-0"> ${title}</h6>
                <p class="card-title m-0 mt-1"> ${bodyFocus}</h3>
                <div class="">
                    <div>
                        <img width="20" src="/User/Images/star-svgrepo-com.png" alt="" srcset="" />
                        <img width="20" src="/User/Images/star-svgrepo-com.png" alt="" srcset="" />
                        <img width="20" src="/User/Images/star-svgrepo-com.png" alt="" srcset="" />
                        <img width="20" src="/User/Images/star-svgrepo-com.png" alt="" srcset="" />
                        <img width="20" src="/User/Images/star-svgrepo-com.png" alt="" srcset="" />
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

                                <img src="Images/Exercise/cart-3-svgrepo-com.png" />

                            </button>
                        </div>

                    </div>
                </div>
            </div>
        </div>
`;


    container.appendChild(row);
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

document.getElementById('filterSubmit').addEventListener('submit', (e) => {

    console.log(multiBodyFoucs)

    multiSelect();
    e.preventDefault();


})


function multiSelect() {
    var lis = $('#MultiSection').select2('data');
    postData("https://localhost:7232/api/ExerciseApi/searchforExercise", {
        bodyFocus: lis.map(op => op.id),
        traningType: [
            "الحركة"
        ],
        difficulty: [
            3
        ],
        equipment: [
            "دمبل"
        ],
        duration: [
            23
        ]

    }).then((data) => {
        console.log(data);
        data.forEach(p => {
            document.getElementById("rowExercisesIndex").innerHTML = ""
            RenderRow(document.getElementById("rowExercisesIndex"), p);
        });

    }).catch((er) => {
        console.error(er);
    });
}


getExercises("rowExercisesIndex");


//function listofIds(id)
//{
//    exIds.push(id);
//}
//async function postIDs(url = "", exId) {


//    const response = await fetch(url, {
//        method: "POST",
//        mode: "cors",
//        cache: "no-cache",
//        credentials: "same-origin",
//        headers: {
//            "Content-Type": "application/json",
//        },
//        redirect: "follow",
//        referrerPolicy: "no-referrer",
//        body: JSON.stringify(exId)
//    });

//    return response.json();
//}

//function renderex(exId) {


//    postData("https://localhost:7232/api/ExerciseApi/GetMultiExercise", exId).then((data) => {
//        console.log(data);
//        console.log('here');
//        data.forEach(p => {
//            RenderRow(document.getElementById("rowExercisesIndex"), p)

//        });

//    }).catch((er) => {
//        console.error(er);
//    });
//}






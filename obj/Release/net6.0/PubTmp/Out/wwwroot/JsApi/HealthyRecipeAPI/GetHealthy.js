
var forms = document.getElementById("FormProgramAdd");
var formSystem = document.getElementById("formProgramSystem");
var DivSystem = document.getElementById("DivSystem");
var SelectHealthy = document.getElementById("SelectHealthy");
var btnSave = document.getElementById("btnSave");
var IdMeal = document.getElementById("IdMeal").value;

getHealthy("SelectHealthy");

function SaveProg(event) {



    DivSystem.classList = "container-lg my-5 d-block";

    btnSave.hidden = true;

    forms.submit();

}

//window.onload = function () {
//    getHealthy("SelectHealthy");





var day = 1;
var week = 1;
var Exercies = [];
var Calend = [];


var selectLengthWeek = document.getElementById("selectLengthWeek");

var SelectExercise = document.getElementById("SelectHealthy");

var selectDays = document.getElementById("selectDays");




var BtnAddHealtyMeal = document.getElementById("BtnAddHealtyMeal");
BtnAddHealtyMeal.addEventListener("click", AddDaysHealtyMeal);


//selectLength.addEventListener("change", LengthProgram);

selectLengthWeek.addEventListener("change", selectLengthWeekFun);
selectDays.addEventListener("change", selectDaysFun);

SelectExercise.addEventListener("change", SelectExerciseFun);
var rowExerciesForm = document.getElementById("rowExerciesForm");

function selectLengthWeekFun(event) {
    week = event.target.value;
}
function selectDaysFun(event) {

    day = event.target.value;


}
function SelectExerciseFun(event) {
    Exercies = [];

    for (var option of SelectHealthy.options) {
        if (option.selected) {
            Exercies.push(option.value);

        }
    }


}




//function LengthProgram(event) {
//    length = event.target.value;
//    selectLengthWeek.innerHTML = "";
//    for (var x = 1; x <= length; x++) {
//        let li = document.createElement("option");
//        li.value = x;
//        li.innerHTML = `الاسبوع  ${x} `;
//        selectLengthWeek.appendChild(li);
//    }



//}


function AddDaysHealtyMeal(event) {

    Calend.push({
        Day: day,
        Week: week,
        Exercies: [Exercies]
    });

    for (var x = 0; x < Exercies.length; x++) {


        var payload = {
            Id: IdProg + Math.random(),
            isComplete: false,
            HealthyRecdpeId: Exercies[x],
            MealPlansId: IdMeal,
            Day: parseInt(day),
            Week: parseInt(week),



        };
    

        var payloadstringify = JSON.stringify(payload);




        addMealHealthyForm(payloadstringify).then((d) => {

            console.table(d);

            if (d !== undefined && d.status === 'ok') {


                console.log("true");
                return;


            }
            else {
                console.log("false");

            }

        });


    }



    formSystem.submit();



}







function ShowMealHealthyModelEdit(modelid, dataObj) {



    let modelElm = document.getElementById(modelid);
    var myModal = new bootstrap.Modal(modelElm, {
        keyboard: false
    })

    modelElm.querySelectorAll('span.field-validation-error').forEach((obj, i, a) => a[i].innerHTML = '');


    if (dataObj !== null) {


        modelElm.querySelector('#ExerciesprogramID').value = dataObj.Id;
        modelElm.querySelector('#Exercies_ProgramsportsProgramId').value = dataObj.SportsProgramId;


        modelElm.querySelector('#selectDays').value = dataObj.Day;

        modelElm.querySelector('#selectLength').value = dataObj.Week;
        modelElm.querySelector('#Exercie').value = dataObj.ExerciseId;

        getHealthy("SelectHealthy");


    }


    myModal.toggle()
}




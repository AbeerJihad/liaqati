
var forms = document.getElementById("FormProgramAdd");
var formSystem = document.getElementById("formSystem");
var DivSystem = document.getElementById("DivSystem");
var SelectExercises = document.getElementById("SelectExercises");
var btnSave = document.getElementById("btnSave");
var IdProg = document.getElementById("IdProg").value;



function SaveProg(event) {



    DivSystem.classList = "container-lg my-5 d-block";

    btnSave.hidden = true;

    forms.submit();

}

window.onload = function () {
    getdata("SelectExercises");

}



var day = 1;
var week = 1;
var Exercies = [];
var Calend = [];


var selectLengthWeek = document.getElementById("selectLengthWeek");

var SelectExercise = document.getElementById("SelectExercises");

var selectDays = document.getElementById("selectDays");




var BtnAdd = document.getElementById("BtnAdd");
BtnAdd.addEventListener("click", AddDaysPrograms);


selectLength.addEventListener("change", LengthProgram);

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

    for (var option of SelectExercise.options) {
        if (option.selected) {
            Exercies.push(option.value);

        }
    }


}




function LengthProgram(event) {
    length = event.target.value;
    selectLengthWeek.innerHTML = "";
    for (var x = 1; x <= length; x++) {
        let li = document.createElement("option");
        li.value = x;
        li.innerHTML = `الاسبوع  ${x} `;
        selectLengthWeek.appendChild(li);
    }



}

function AddDaysPrograms(event) {

    Calend.push({
        Day: day,
        Week: week,
        Exercies: [Exercies]
    });

    for (var x = 0; x < Exercies.length; x++) {

    
        var payload = {
            Id: IdProg + Math.random(),
            isComplete: false,
            exerciseId: Exercies[x],
            sportsProgramId: IdProg,
            Day: parseInt(day),
            Week: parseInt(week),

         

        };

        var payloadstringify =  JSON.stringify(payload);

       


        addProgExerForm(payloadstringify).then((d) => {

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


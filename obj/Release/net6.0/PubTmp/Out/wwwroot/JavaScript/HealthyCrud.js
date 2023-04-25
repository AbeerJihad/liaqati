

window.onload = function () {
    getdataHealty("SelectgetdataHealties");

}


var day = 1;
var week = 1;
var Healthy = [];
var Calend = [];


var forms = document.getElementById("FormProgramAdd");

var formHealthySystem = document.getElementById("formHealthySystem");

var DivSystem = document.getElementById("DivSystem");
var SelectgetdataHealties = document.getElementById("SelectgetdataHealties");
var btnSave = document.getElementById("btnSave");
var MealId = document.getElementById("MealIdSystem").value;

var selectDays = document.getElementById("selectDays");

var selectLengthWeek = document.getElementById("selectLengthWeek");

var SelectHealty = document.getElementById("SelectgetdataHealties");





var BtnAddHealthyRecipe = document.getElementById("BtnAddHealthyRecipe");
BtnAddHealthyRecipe.addEventListener("click", AddDaysHealthy);



selectLengthWeek.addEventListener("change", selectLengthWeekFun);
selectDays.addEventListener("change", selectDaysFun);

SelectgetdataHealties.addEventListener("change", SelectHealtyFun);

function selectLengthWeekFun(event) {
    week = event.target.value;
}
function selectDaysFun(event) {
    day = event.target.value;

}
function SelectHealtyFun(event) {
    Healthy = [];

    for (var option of SelectHealty.options) {
        if (option.selected) {
            Healthy.push(option.value);

        }
    }

}

function AddDaysHealthy(event) {

    Calend.push({
        Day: day,
        Week: week,
        Healthy: [Healthy]
    });

 

    for (var x = 0; x < Healthy.length; x++) {


        var payload = {
            Id: MealId + Math.random(),
            isComplete: false,
            HealthyRecdpeId: Healthy[x],
            MealPlansId: MealId,
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

    formHealthySystem.submit();



}


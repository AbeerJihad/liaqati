
function ShowProgExerModelEdit(modelid, dataObj) {



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

        getdata("SelectExercises");


    }


    myModal.toggle()
}





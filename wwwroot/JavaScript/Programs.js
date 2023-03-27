
//var FormMultiSeleected = document.getElementById("FormProgramAdd");


let myModal;



function ShowModelAdd(modelid, dataObj) {


    let modelElm = document.getElementById(modelid);
     myModal = new bootstrap.Modal(modelElm, {
        keyboard: false
    })

    modelElm.querySelectorAll('span.field-validation-error').forEach((obj, i, a) => a[i].innerHTML = '');


    if (dataObj !== null) {
        //modelElm.querySelector('#Student_Id').value = dataObj.Id;

        //modelElm.querySelector('#Student_Name').value = dataObj.Name;


    }



    myModal.show()
}


function ShowProgExerModelEdit(modelid, dataObj) {



    let modelElm = document.getElementById(modelid);
    var myModal = new bootstrap.Modal(modelElm, {
        keyboard: false
    })

    modelElm.querySelectorAll('span.field-validation-error').forEach((obj, i, a) => a[i].innerHTML = '');


    if (dataObj !== null) {

        
        modelElm.querySelector('#ExerciesprogramID').value = dataObj.Id;
        modelElm.querySelector('#exercies_programSportsProgramId').value = dataObj.sportsProgramId;


        modelElm.querySelector('#selectDays').value = dataObj.Day;

        modelElm.querySelector('#selectLength').value = dataObj.Week;
        modelElm.querySelector('#Exercie').value = dataObj.exerciseId;

        getdata("SelectExercises");


    }

   
    myModal.toggle()
}





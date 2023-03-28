
//var FormMultiSeleected = document.getElementById("FormProgramAdd");






function ShowModelAdd(modelid, dataObj) {


    let modelElm = document.getElementById(modelid);
    var myModal = new bootstrap.Modal(modelElm, {
        keyboard: false
    })

    modelElm.querySelectorAll('span.field-validation-error').forEach((obj, i, a) => a[i].innerHTML = '');


    if (dataObj !== null) {
        //modelElm.querySelector('#Student_Id').value = dataObj.Id;

        //modelElm.querySelector('#Student_Name').value = dataObj.Name;


    }



    myModal.show()
}

function FinishAddExercise(tag) {
    var form = tag.parentElement.parentElement.parentElement.parentElement;


    form.submit();



}

//FormMultiSeleected.addEventListener("submit", MultSelectExercise)



var select = document.getElementById("SelectExercise");

//function MultSelectExercise(event) {

//    var selected = [];
//    for (var option of select.options) {
//        if (option.selected) {
//            selected.push(option.value);
//        }
//    }


//}
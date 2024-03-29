﻿var checkAll = document.getElementById('chk-all');
//var BtnCancelSelection = document.getElementById('BtnCancelSelection');
//var noOfSelectedItem = document.getElementById('noOfSelectedItem');
var BtnClose = document.getElementById('BtnClose');
var imgBoxes = document.querySelectorAll('.img__box');
var image__viewer = document.querySelector('.image__viewer');
var deleteMultiForm = document.querySelector('.deleteMultiForm');
var Tbl = document.getElementById('Tbl');
//var BtnDelete = document.getElementById('BtnDelete');
//var confirmText = document.getElementById('confirmText');
//var BtnConfirmDelete = document.getElementById('BtnConfirmDelete');
var checkBoxes = Tbl.querySelectorAll("tbody tr label input");
//var confirmMsg = document.querySelector(".confirm-massage");

BtnClose.addEventListener('click', (e) => {
    image__viewer.classList.add('d-none');
    image__viewer.classList.remove('d-flex');
    image__viewer.querySelector('.img__box2 img').src = '';
    image__viewer.querySelector('.title').innerHTML = '';

},)
//BtnCancelSelection.addEventListener('click', (e) => {
//    checkBoxes.forEach((value) => value.checked = false);
//    CheckBoxChecks();
//},)
//confirmText.addEventListener('input', EnableDisableBtn)
//confirmText.addEventListener('change', EnableDisableBtn)
//function EnableDisableBtn(e) {
//    console.log(BtnConfirmDelete.getAttribute('disabled'))
//    if (e.target.value == "تأكيد") {
//        BtnConfirmDelete.removeAttribute('disabled')
//    } else {
//        BtnConfirmDelete.setAttribute('disabled', true)

//    }

//}
//BtnDelete.addEventListener('click', (e) => {
//    const modalConfirmation = new bootstrap.Modal(document.getElementById('modalConfirmation'), {
//        keyboard: false
//    })
//    modalConfirmation.toggle();
//    confirmMsg.innerHTML = `أنت على وشك حذف ${BtnDelete.getAttribute('data-noOfSelected')} ${BtnDelete.getAttribute('data-name')} . هل أنت واثق؟`;
//    CheckBoxChecks();
//},)
checkAll.addEventListener('change', function () {
    if (this.checked) {
        checkBoxes.forEach((value) => value.checked = true);
    } else {
        checkBoxes.forEach((value) => value.checked = false);
    }
    CheckBoxChecks();
});

checkBoxes.forEach((value) => {
    value.addEventListener('change', CheckBoxChecks);

})
function CheckBoxChecks() {
    let IsChecked = 0;
    let NotChecked = 0;
    let arra = [];
    for (var i = 0; i < checkBoxes.length; i++) {
        if (checkBoxes[i].checked) {
            IsChecked += 1;
            arra.push(checkBoxes[i].value)
        } else if (!checkBoxes[i].checked) {
            NotChecked += 1;
        }
    }
    console.log(arra);
    //noOfSelectedItem.innerHTML = IsChecked;
    //BtnDelete.setAttribute('data-noOfSelected', IsChecked)
    if (IsChecked > 0 && IsChecked < checkBoxes.length) {
        checkAll.indeterminate = true;
        deleteMultiForm.classList.remove('d-none');
    } else if (IsChecked == 0) {
        checkAll.indeterminate = false;
        checkAll.checked = false;
        deleteMultiForm.classList.add('d-none');


    } else if (IsChecked == checkBoxes.length) {
        checkAll.indeterminate = false;
        checkAll.checked = true;
        deleteMultiForm.classList.remove('d-none')

    }
}
imgBoxes.forEach((img) => {
    img.addEventListener('click', (e) => {
        if (e.target.nodeName.toLocaleLowerCase() == "img") {
            image__viewer.classList.remove('d-none');
        }
        image__viewer.classList.add('d-flex');
        image__viewer.querySelector('.img__box2 img').src = e.target.src;
        image__viewer.querySelector('.title').innerHTML = e.target.alt;
    });
})
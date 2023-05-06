
function DeleteFun(tag) {

    var parent = tag.parentElement;

    Swal.fire({
        title: 'هل انت متأكد/ة؟',
        text: "لن تتمكن من التراجع عن هذا القرار!!!",
        //icon: 'warning  ',
        showCancelButton: true,
        confirmButtonColor: '#a566c8',
        cancelButtonColor: '#ff7273',
        confirmButtonText: 'نعم أنا متأكد قم بحذفه',
        cancelButtonText: 'إلغاء'
    }).then((result) => {
        if (result.isConfirmed) {
            //Swal.fire(
            //    'Deleted!',
            //    'Your file has been deleted.',
            //    'success'
            //);
            parent.submit();

        }
    })


}
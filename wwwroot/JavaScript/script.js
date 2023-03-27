
function DeleteFun(tag) {

    //var elm = eo.target;
    //var tagname1 = elm.nodeName;
    //// alert(tagname1);

    //if (tagname1.toLowerCase() == "img") {



    var parent = tag.parentElement;

    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            Swal.fire(
                'Deleted!',
                'Your file has been deleted.',
                'success'
            );
            parent.submit();

        }
    })


}
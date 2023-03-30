
var formAddExercies = document.getElementById("formAddExercies");



async function addExerciesForm(data) {

    console.log(data);

    try {

        const response = await fetch("https://localhost:7232/api/ExerciseApi",
            {
                method: "POST",

                body: data,
                headers: {
                    'Content-type': 'application/json; charset=UTF-8',
                }
            });

        if ([200, 201, 202].indexOf(response.status) != -1) {
            let result = await response.json();
            return { status: 'ok', data: result };
        } else {
            let result = await response.json();
            return { status: 'error', data: result };
        }


    } catch (err) {
        console.error(err);
    }

}




function FinishAddExercises(tag) {


    var payloadExer = {
        Id: Math.random().toString(),
        Title: formAddExercies.Title.value,
        Detail: formAddExercies.Detail.value,
        TraningType: formAddExercies.TraningType.value,
        Price: parseFloat(formAddExercies.Price.value),
        Difficulty: formAddExercies.Difficulty.value,
        Duration: formAddExercies.Duration.value,
        Equipments: formAddExercies.Equipments.value
    };

 var JSExercies =   JSON.stringify(payloadExer);

    addExerciesForm(JSExercies).then((d) => {

      

        if (d !== undefined && d.status === 'ok') {

         

            formAddExercies.reset();

            var myModal = new bootstrap.Modal(document.getElementById("editModel"), {
                keyboard: false
            })
            //myModal.show();
            //myModal.hide();

            getdata("SelectExercises");


        }
        else {
        }

    });


}

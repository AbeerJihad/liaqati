
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


    var data = new FormData();
    data.append("Title", formAddExercies.Title.value);
    data.append("Detail", formAddExercies.Detail.value);
    data.append("TraningType", formAddExercies.TraningType.value);
    data.append("Price", parseFloat(formAddExercies.Price.value));
    data.append("Difficulty", formAddExercies.Difficulty.value);
    data.append("DEx", formAddExercies.DEx.value);
    data.append("Equipments", formAddExercies.Equipments.value);


    var payloadExer = {
        Id: Math.random().toString(),
        Title: formAddExercies.Title.value,
        Detail: formAddExercies.Detail.value,
        TraningType: formAddExercies.TraningType.value,
        Price: parseFloat(formAddExercies.Price.value),
        Difficulty: formAddExercies.Difficulty.value,
        DEx: formAddExercies.DEx.value,
        Equipments: formAddExercies.Equipments.value
    };

    var JSExercies = JSON.stringify(payloadExer);

    addExerciesForm(JSExercies).then((d) => {



        if (d !== undefined && d.status === 'ok') {



            formAdd.reset();

            myModal.toggle();


        }
        else {
        }

    });


}

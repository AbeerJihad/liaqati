
let lstExercises = [];

async function getExercise(SelectExercises) {
    var xxx = document.getElementById(SelectExercises);

    let result = [];
    try {
        const response = await fetch("https://localhost:7232/api/ExerciseApi/AllExercise", {
            method: "GET",
        });
        if (response.status === 200) {
            result = await response.json();
        }
        else {
            console.error(json);
            //`Error: ${json.title}`;
        }
    } catch (err) {
        console.error(err);
    }
    xxx.innerHTML = "";

    return result;
}


async function getdata(SelectExercises) {
    lstExercises = await getExercise(SelectExercises);
    lstExercises.forEach((p) =>
        RenderSelect(SelectExercises));

}


function RenderSelect(SelectExercises) {

    var xx = document.getElementById(SelectExercises);
    xx.innerHTML = "";

    for (element of lstExercises) {
        let li = document.createElement("option");
        li.value = element.id;

        li.innerHTML = element.title;
        xx.appendChild(li);
    }

}


//async function addExerciesForm(data) {

//    console.log(data);
//    alert("api");

//    try {

//        const response = await fetch("https://localhost:7232/api/ExerciseApi",
//            {
//                method: "POST",

//                body: data,
//                headers: {
//                    'Content-type': 'application/json; charset=UTF-8',
//                }
//            });

//        if ([200, 201, 202].indexOf(response.status) != -1) {
//            let result = await response.json();
//            return { status: 'ok', data: result };
//        } else {
//            let result = await response.json();
//            return { status: 'error', data: result };
//        }


//    } catch (err) {
//        console.error(err);
//    }

//}



async function addProgExerForm(data) {

    try {

        const response = await fetch("https://localhost:7232/api/ProgramExercies/AddProgramExercies",
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




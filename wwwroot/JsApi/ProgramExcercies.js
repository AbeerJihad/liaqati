
let lstprogramExercies = [];
var selectElement = document.getElementById("tableBodyApi");

var programid = document.getElementById("IdProg");
var progid = programid.value;

async function getprogramExercies() {

    let result = [];
    try {
        const response = await fetch(`https://localhost:7232/api/ProgramExercies/AllProgramExercies/${progid}`, {
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
    selectElement.innerHTML = "";

    return result;
}





async function getdata() {


    lstprogramExercies = await getprogramExercies();
    lstprogramExercies.forEach((p) =>
        RenderSelect(selectElement));

}





function RenderSelect(selectElement) {
    for (element of lstprogramExercies) {
        let tr = document.createElement("tr");
        tr.innerHTML =
            `
        <td>${element.Day}  اليوم </td>
        <td>${element.Week}   الاسبوع</td>
        <td></td>
            `;
        selectElement.appendChild(tr);
    }

}


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






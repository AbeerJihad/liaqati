


let lstHealthy = [];

async function getHealthy(Healthy) {
    var item = document.getElementById(Healthy);
    let result = [];
    try {
        const response = await fetch("https://localhost:7232/api/HealthyApi/AllHealthyRecipe", {
            method: "GET",
        });
        if (response.status === 200) {
            result = await response.json();
            console.log(result);
        }
        else {
            console.error(json);
            //`Error: ${json.title}`;
        }
    } catch (err) {
        console.error(err);
    }
    item.innerHTML = "";

    return result;
}


async function getdataHealty(Healthy) {
    lstHealthy = await getHealthy(Healthy);
    lstHealthy.forEach((p) =>
        RenderSelect(Healthy));

}


function RenderSelect(Healthy) {

    var item = document.getElementById(Healthy);
    item.innerHTML = "";

    for (element of lstHealthy) {
        let li = document.createElement("option");
        li.value = element.id;

        li.innerHTML = element.title;
        item.appendChild(li);
    }

}




window.onload = function () {
    getdataHealty("SelectHealthy");

}


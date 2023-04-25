let txtPreparationMethod = document.getElementById("txtPreparationMethod");
let HealthyRecipes_PreparationMethod = document.getElementById("HealthyRecipes_PreparationMethod");
let error = document.getElementById("error");
let BtnAdd = document.getElementById("BtnAdd");
let NoofSteps = document.getElementById("NoofSteps");
let StepsReviewer = document.getElementById("StepsReviewer");
var listOfSteps = [];
BtnAdd.addEventListener("click", () => {
    error.innerText = "";
    HealthyRecipes_PreparationMethod.value = "";
    if (txtPreparationMethod.value && txtPreparationMethod.value !== "") {
        if (listOfSteps.indexOf(txtPreparationMethod.value) === -1) {
            listOfSteps.push(txtPreparationMethod.value);
            StepsReviewer.innerHTML = "";
            listOfSteps.forEach((txt, index, array) => { RenderItems(txt); });
        } else {
            error.innerText = "لقد أضفت هذه الخطوة سابقاً"
        }
        txtPreparationMethod.value = "";
    }
    HealthyRecipes_PreparationMethod.value = listOfSteps.join(",");
    NoofSteps.innerText = `${listOfSteps.length} الخطوات`;
});
function RenderItems(text) {
    let step = document.createElement("span");
    step.className = "ingredient";
    step.style.cursor = "pointer";
    step.textContent = text;
    step.onclick = () => {
        StepsReviewer.removeChild(step);
        listOfSteps.splice(listOfSteps.indexOf(text), 1);
        HealthyRecipes_PreparationMethod.value = listOfSteps.join(",");
    };

    StepsReviewer.appendChild(step);
}



let txtIngredients = document.getElementById("txtIngredientName");
let txtIngredientQuantity = document.getElementById("txtIngredientQuantity");
let txtIngredientUnit = document.getElementById("txtIngredientUnit");
let txtAreaIngredients = document.getElementById("txtAreaIngredients");
let BtnAddIngredients = document.getElementById("BtnAddIngredients");
let NoFoIngredients = document.getElementById("NoFoIngredients");
let ingredients_container = document.getElementById("ingredients_container");
var listOfIngredients = [];
let id = 0;
let editedId = 0;
let isAdd = false;
BtnAddIngredients.addEventListener("click", () => {
    if (txtIngredients.value && txtIngredients.value !== "" && txtIngredientUnit.value && txtIngredientUnit.value !== "" && txtIngredientQuantity.value && txtIngredientQuantity.value !== "") {
        listOfIngredients.forEach((txt, index, array) => { if (txt.Id === editedId) { isAdd = true; return; } })
        if (isAdd) {
            var index = listOfIngredients.indexOf(listOfIngredients.find((item) => item.Id == editedId));
            if (index > -1) {
                listOfIngredients[index] = { Id: editedId, Name: txtIngredients.value, Quantity: txtIngredientQuantity.value, Unit: txtIngredientUnit.value };
                RenderAllIngredients();
                isAdd = false;
                editedId = 0;
            }
        }
        else {
            let isExist = false;
            listOfIngredients.forEach((txt, index, array) => { if (txt.Name === txtIngredients.value) { isExist = true; return; } })
            if (!isExist) {
                id++;
                listOfIngredients.push({ Id: id, Name: txtIngredients.value, Quantity: txtIngredientQuantity.value, Unit: txtIngredientUnit.value });
                RenderAllIngredients();
            } else {
                error.innerText = "لقد أضفت هذا المكون سابقاً"
            }
        }
        txtIngredients.value = "";
        txtIngredientQuantity.value = "";

    }

    NoFoIngredients.innerText = `${listOfIngredients.length} المكونات`;
});



function Delete(Id) {
    listOfIngredients.splice(listOfIngredients.indexOf(listOfIngredients.find((item) => item.Id == Id)), 1);
    RenderAllIngredients();
}
function Edit(Id) {
    editedId = Id;
    var item = listOfIngredients.find((item) => item.Id == Id);
    txtIngredients.value = item.Name
    txtIngredientQuantity.value = item.Quantity
    txtIngredientUnit.value = item.Unit;
}

function RenderAllIngredients() {
    txtAreaIngredients.value = "";
    ingredients_container.innerHTML = "";
    listOfIngredients.forEach((inter) => {
        CreateIngredients(inter);
        txtAreaIngredients.value += inter.Name + "," + inter.Quantity + "," + inter.Unit + "\n"
    });
}
function CreateIngredients({ Id, Name, Quantity, Unit }) {
    let ingredient = document.createElement("tr");
    ingredient.style.cursor = "pointer";
    ingredient.innerHTML = `  <td>${Name}</td><td >${Quantity}</td><td>${Unit}</td><td><div class="d-flex flex-nowrap"><a onclick="Edit(${Id})" class="btn" style="background-color: #8763b320; color:#3c077d;  padding: 0.375rem 0.75rem;" type="button"><i class="bi bi-pencil-square"></i></a><a onclick="Delete(${Id})" class="btn" style=" background-color: #d22d3d20; color:#d22d3d;padding: 0.375rem 0.75rem;"><i class="bi bi-trash"></i></a></div></td>`;

    ingredients_container.appendChild(ingredient);
}

window.onload = () => {
    if (HealthyRecipes_PreparationMethod.value.length > 0) {
        listOfSteps = HealthyRecipes_PreparationMethod.value.split(',');
        listOfSteps.forEach((txt, index, array) => { RenderItems(txt); });
    }
    if (txtAreaIngredients.value.length > 0) {
        list = txtAreaIngredients.value.trim().split('\n');
        list.forEach((txt, index, array) => {
            var a = txt.split(',');
            if (txt !== "")
                listOfIngredients.push({
                    Name: a[0],
                    Quantity: a[1],
                    Unit: a[2],
                });
            RenderAllIngredients();
        });

    }
}
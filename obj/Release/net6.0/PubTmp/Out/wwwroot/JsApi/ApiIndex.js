async function getLatesMealPlan(rowMealPlan) {
    let url = "/api/MealPlanApi/LatesMealPlans";

    fetch(url, {
        method: "GET"

    }).then((Response) =>
        Response.json()
    ).then((data) => {

        for (var x = 0; x < 4; x++) { RenderMealPlan(rowMealPlan, data[x]) }

        // data.forEach(meal => RenderMealPlan(rowMealPlan, meal))
    }).catch(xx => {
        console.log(xx);
    })
}


function RenderMealPlan(rowMealPlan, { image, Services, numsubscribers, Id }) {


    let div = document.createElement("div");
    div.className = "col-12 col-md-6 col-lg-3 p-2";
    div.innerHTML =
        `<div class="card">
        <div class="position-relative">
            <img src="${image}" class="card-img-top" alt="..." />
            <img width="40" class="position-absolute" style="top: 20px; right: 20px" src="./Images/heart-svgrepo-com (1).png" alt="" srcset="" />
        </div>
        <div class="card-body">
            <h5 class="card-title mb-3">${Services.title}</h5>
            <p class="card-text">${Services.description}</p>
            <div class="d-flex justify-content-between">
                <div>
                    <h6 class="d-inline-block ms-2 fw-bold">عدد المشتركين</h6>
                    <div style="background-color: #ffe9cb" class="rounded-pill d-inline-block fw-bold align-middle p-2" > ${numsubscribers} </div>
                </div>
                <div>
                    <h5 class="d-inline-block fw-bold text-danger align-middle ms-1 mt-2" >${Services.price}</h5>
                    <img width="20" src="./Images/cart-3-svgrepo-com.png" alt="" srcset="" />
                </div>
            </div>
          </div>
          </div>`;
    rowMealPlan.appendChild(div);

}

var rowMealPlanIndex = document.querySelector("#rowMealPlanIndex");
getLatesMealPlan(rowMealPlanIndex);


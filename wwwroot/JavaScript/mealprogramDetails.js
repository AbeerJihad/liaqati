
async function countHealthyMeal(id, week, day) {


    let result;
    try {
        const response = await fetch(`https://localhost:7232/api/MealPlanApi/CountExersie?id=${id}&week=${week}&day=${day}`, {
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
    // selectElement.innerHTML = "";

    return result;






}
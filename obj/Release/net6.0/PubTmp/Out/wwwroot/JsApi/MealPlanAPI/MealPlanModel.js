async function getMealPlans(categoryId, curPage) {
    let url = '';
    let result = [];
    try {
        if (categoryId === null) {
            url = `/api/MealPlanApi/search?SearchTearm=&CurPage=` + curPage + `&Size=9&SortBy=id&SortOrder=`;
        }
        else
            url = `/api/MealPlanApi/search?CategoryId=` + categoryId + `&SearchTearm=&CurPage=` + curPage + `&Size=9&SortBy=id&SortOrder=`;

        //MinPrice=${null}&MaxPrice=${null}&
        const response = await fetch(url, {
            method: "GET",
            headers: { "Content-Type": "application/json" },
            redirect: "follow",
        });
        if (response.status === 200) {
            result = await response.json();
        }
        else {
            console.error(json);
            //`Error: ${json.title}`;
        }
    } catch (error) {
        console.error(error);
    }
    return result;
}


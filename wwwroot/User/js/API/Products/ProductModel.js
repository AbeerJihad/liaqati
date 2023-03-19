async function getProducts(categoryId) {

    let url = '';
    let result = [];
    try {
        if (categoryId === null) {
            url = '/api/ProductApi/AllProduct';
        }
        else
            url = `/api/ProductApi/GetProductsByCatId/${categoryId}`;

        const response = await fetch(url, {
            method: "GET", // *GET, POST, PUT, DELETE, etc.
            headers: {
                "Content-Type": "application/json",
                // 'Content-Type': 'application/x-www-form-urlencoded',
            },
            redirect: "follow", // manual, *follow, error
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

async function getCategories() {

    let result = [];
    try {
        const response = await fetch("/api/CategoriesApi", {
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
    return result;
}



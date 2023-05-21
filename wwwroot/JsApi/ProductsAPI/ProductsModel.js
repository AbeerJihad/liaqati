async function getProducts(data = {}) {
    let url = '';
    let result;
    try {
        const response = await fetch('/api/ProductApi/SearchForProduct', {
            method: "POST",
            mode: "cors",
            cache: "no-cache",
            credentials: "same-origin",
            headers: { "Content-Type": "application/json" },
            redirect: "follow",
            referrerPolicy: "no-referrer",
            body: JSON.stringify(data)

        });
        if (response.status === 200) {
            result = await response.json();
            console.log(result);
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



async function AddFavoritesToProduct(id) {

    let result;
    try {
        const response = await fetch(`/api/FavoritesApi/AddFavorites/${id}`, {
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



async function AddFavoritesToProduct(id) {

    let result;
    try {
        const response = await fetch(`/api/FavoritesApi/AddFavorites/${id}`, {
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


async function AddCart(id) {

    let result;
    try {
        const response = await fetch(`/api/CartApi/AddToCart/${id}`, {
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




async function CountCart() {

    let result;
    try {
        const response = await fetch(`/api/CartApi/CountCart`, {
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


async function CountFunCart() {

    var int = await CountCart();
    countofcart.innerHTML = int;
}
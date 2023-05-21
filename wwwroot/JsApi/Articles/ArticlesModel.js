


async function AddFavoritesToArticles(id) {

    let result;
    try {
        const response = await fetch(`/api/ArticlesApi/AddFavoritesToArticles/${id}`, {
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

async function AddFavoriteArticles(id,tag) {
    var IsAdd = await AddFavoritesToArticles(id);
    if (IsAdd.toString() === "true") {
        tag.firstElementChild.innerHTML = `<i class="bx bxs-heart h4 m-0 text-danger "></i>`
    }
    else {
        tag.firstElementChild.innerHTML = `<i class="bx bxs-heart  text-dark h4 m-0"></i>`
    }


}

﻿async function getUsers(data = {}) {
    let url = '';
    let result;
    try {
        const response = await fetch('https://localhost:7232/api/UserApi/searchforExperts', {
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


async function addMealHealthyForm(data) {

    try {

        const response = await fetch("https://localhost:7232/api/Mealhealthy/AddMealhealthy",
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




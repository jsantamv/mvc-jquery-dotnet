

const getData = () => {
    var myHeaders = new Headers();
    myHeaders.append("Content-Type", "application/json");

    //var body = JSON.stringify({
    //    "StartDate": "2022-01-01",
    //    "EndDate": "2022-01-01",
    //    "aaNAME": "VT04000",
    //    "TicketId": "22",
    //    "Status": "Rejected"
    //});

    var requestOptions = {
        method: 'POST',
        headers: myHeaders,
        body: JSON.stringify({
            "StartDate": "2022-01-01",
            "EndDate": "2022-01-01",
            "aaNAME": "VT04000",
            "TicketId": "22",
            "Status": "Rejected"
        })
    };

    console.log(requestOptions);

    fetch("/Home/List", requestOptions)
        .then(response => response.json())
        .then(result => console.log(result))
        .catch(error => console.log('error', error));
}


async function getUsers() {
    try {
        const response = await fetch("https://jsonplaceholder.typicode.com/users/1");

        if (!response.ok) {
            throw new Error("Request failed");
        }

        const data = await response.json();
        console.log (data)
        if(  data instanceof Array){
             for (let i = 0; i < data.length; i++) {
            const tableBody = document.getElementById("u").getElementsByTagName('tbody')[0];
            const newRow = tableBody.insertRow();
            newRow.insertCell(0).textContent = data[i]['id'];
            newRow.insertCell(1).textContent = data[i]['name'];
            newRow.insertCell(2).textContent = data[i]['email'];
            newRow.insertCell(3).textContent = data[i]['address']['city'];
            newRow.insertCell(4).textContent = data[i]['address']['zipcode'];
            newRow.insertCell(5).textContent = data[i]['phone'];
        }
        }else {
            const tableBody = document.getElementById("u").getElementsByTagName('tbody')[0];
            const newRow = tableBody.insertRow();
            newRow.insertCell(0).textContent = data['id'];
            newRow.insertCell(1).textContent = data['name'];
            newRow.insertCell(2).textContent = data['email'];
            newRow.insertCell(3).textContent = data['address']['city'];
            newRow.insertCell(4).textContent = data['address']['zipcode'];
            newRow.insertCell(5).textContent = data['phone'];
        }
       

    } catch (err) {
        console.error(err);
    }
}

getUsers()
const fs = require('fs');

const [,, command, ...args] = process.argv;
let data = [];
const filePath ="products.json";

switch (command) {
    case "add":
        add(args[0], args[1]);
        break;
    case "read":
        read();
        break;
    case "delete":
        remove(args[0]);
        break;
    case "update":
        const [,...keyValPairs] = args
        // console.log(keyValPairs);
        update(args[0], keyValPairs);
        break; 
}

function add(productName, price) {
    const product = {
        id: Date.now(), 
        productName,
        price
    };
    fillArray();
    data.push(product);
    fs.writeFileSync(filePath, JSON.stringify(data));
}

function fillArray (){
    const fileContent = fs.readFileSync(filePath, 'utf8');
    data = JSON.parse(fileContent || "[]");
}

function read (){
    fillArray();
    for(let i =0 ; i < data.length ; i++){
        console.log(` item : ${data[i].productName} , price : ${data[i].price}`);
    }
}
function remove(id){
    fillArray();
    const newData = data.filter(item => item.id != id);
    if (newData.length === data.length) {
        console.log("Product not found");
        return;
    }
    data = newData;
    fs.writeFileSync(filePath, JSON.stringify(data));
}
// Node fileName update id --name “new value” --price new value 
function update(id, vals) {
    fillArray();
    
    const product = data.find(item => item.id == id);

    if (!product) {
        console.log("Product not found");
        return;
    }

    for (let i = 0; i < vals.length; i += 2) {
        let key = vals[i].replace('--', '');
        let value = vals[i + 1];

        if (key === "name") key = "productName";
        if (product.hasOwnProperty(key)) {
            product[key] = value;
        }
    }

    fs.writeFileSync(filePath, JSON.stringify(data, null, 2));
}

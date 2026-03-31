import express from "express";
import fs from "fs/promises";
import { v4 as uuidv4 } from "uuid";

const read = async () => {
  const data = await fs.readFile("./products.json", "utf-8");
  return JSON.parse(data);
};

const write = async (products) => {
  await fs.writeFile("./products.json", JSON.stringify(products));
};

const createProducts = (id,name, price ,phone) => {
  return { id , name, price , phone };
};
const app = express();
//"name": "Phone", "price"

app.listen(3000, () => {
  console.log("Server running");
});


app.use(express.json());

app.post("/products", async (req, res) => {
    try{
    const { name, phone ,price } = req.body;
    if (!name || !phone || !price) {
      return res.status(400).json({ message: "name, Phone, and price are required" });
    }
    const products = await read();
    const newPorduct = createProducts(uuidv4(), name, price, phone);
    products.push(newPorduct);
    await write(products);
    return res.status(201).json({ data: newPorduct });
    
    }catch (error) {
        res.status(500).json({ message: error.message });
    }
   
});

app.get("/products", async (req, res) => {
  try {
    const products = await read();
    return res.status(200).json({ data: products });
  } catch (error) {
    res.status(500).json({ message: error.message });
  }
});

app.get("/products/:id", async (req, res) => {
  try {
    const { id } = req.params;
    const products = await read();
    const product = products.find((p) => p.id === id);
    if (!product) {
      return res.status(404).json({ message: "Product not found" });
    }
    res.status(200).json({ data: product });
  } catch (error) {
    res.status(500).json({ message: error.message });
  }
});

app.delete("/products/:id",async (req , res)=>{
  try{
    let {id} = req.params;
    let products = await read();
    let product = products.find( p => p.id ==id);
    if(!product)
      res.status(404).json({ message: "Product not found" });
    else{
      products = products.filter(p=>p.id!=id);
      await write(products);
       res.status(200).json({ data: product });
    }
  }catch(error){
    res.status(500).json({ message: error.message });
  }

})

app.put("/products/:id", async (req, res) => {
  try {
    const { id } = req.params;
    const { name, price, phone } = req.body;
    if (!name && !price && !phone) {
      return res.status(400).json({
        success: false,
        message: "Name or price or phone required to update",
      });
    }
    let products = await read();
    const index = products.findIndex((p) => p.id === id);
    if (index === -1) {
      return res.status(404).json({
        success: false,
        message: "Product not found",
      });
    }
    if (name) {
      products[index].name = name;
    }
    if (price) {
      products[index].price = price;
    }
    if (phone) {
      products[index].phone = phone;
    }
    await write(products);
    res.status(200).json({
      data: products[index],
    });
  } catch (error) {
    res.status(500).json({ message: error.message });
  }
});
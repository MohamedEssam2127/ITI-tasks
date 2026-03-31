import express from "express";
import mongoose from "mongoose";
import productRoute from "./routes/ProductRoute.js";

const app=express();

app.use(express.json());

app.use("/product",productRoute)


mongoose.connect('mongodb://localhost:27017/products').then(()=>{
    console.log("connected to database");
}).catch((err)=>{
    console.log("error connecting to database",err);
})
app.listen(3000,()=>{
    console.log("server is running on port 3000");

})
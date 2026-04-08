import express from "express";
import mongoose from "mongoose";
import productRoute from "./routes/ProductRoute.js";
import CategoryRoute  from './routes/CategoriesRoute.js';
import UserRoute  from './routes/UserRoute.js';
import dotenv from "dotenv";
import {connectDBs} from "./config/dbconfig.js"

const port =process.env.PORT||3000;
const app=express();
app.use(express.json());
connectDBs()
dotenv.config()
app.use("/product",productRoute)
app.use("/Categories",CategoryRoute);
app.use("/user",UserRoute);



app.listen(port,()=>{
    console.log("server is running on port 3000");
})

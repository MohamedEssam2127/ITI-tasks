import mongoose from "mongoose";

export const connectDBs = async () => {
  try {
    await mongoose.connect("mongodb://localhost:27017/products");

    console.log("connected");
  } catch (err) {
    console.log(err);
  }
};

import mongoose from "mongoose";

const { Schema } = mongoose;

const productSchema = new Schema({
    name: {
        type: String,
        required: true,
        trim: true
    },
    price: {
        type: Number,
        required: true,
        min: 0
    }
});

const productModel = mongoose.model("Product", productSchema);

export default productModel;
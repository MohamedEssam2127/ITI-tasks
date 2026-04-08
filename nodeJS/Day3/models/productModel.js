import mongoose from "mongoose";

const { Schema } = mongoose;

// 2 Product Model
// •	Fields: 
// o	name (String, required) 
// o	price (Number, required) 
// o	category (ObjectId, reference to Category, required) 
// o	createdAt 
// o	updateAt

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
    },
    category:{
        type:Schema.Types.ObjectId,
         ref:"category",
         required: true
    }
},{timestamps:true});

const productModel = mongoose.model("Product", productSchema);

export default productModel;
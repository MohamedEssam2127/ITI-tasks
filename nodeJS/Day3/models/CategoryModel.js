import mongoose from "mongoose";

const { Schema } = mongoose;

// o	name (String, required, unique) 
// o	description (String, optional)

const categorySchema = new Schema ({
    name:{
        type: String,
        required: true,
        trim: true,
        unique:true
    },
    description:{
        type:String,
    }
})
const categoryModel = mongoose.model("category", categorySchema);

export default  categoryModel ;
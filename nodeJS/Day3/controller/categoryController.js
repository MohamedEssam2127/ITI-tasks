import Category from '../models/CategoryModel.js'
import Product from '../models/productModel.js'


// •	Create Category 
// •	Get All Categories 
// •	Get All Products Under a Category

export const createCategory = async (req,res)=>{
    try{
    const {name, description } = req.body ;
    if (!name || !description) {
        return res.status(400).json({message: "name and price are required"});
    }
    const category = await Category.create({name,description});
     return res.status(201).json({message: "Category created successfully",data: category,});
  } catch (error) {
    return res.status(500).json({message: error.message,});
  }
}

export const getAllCategories = async (req,res)=>{
    try{
        const categories = await Category.find();
        return res.status(200).json(categories);
    }catch(error){
        return res.status(500).json({message : error.message})
    }
}

export const getAllProductsUnderaCategory= async (req, res)=>{
    try{
        const { id } = req.params;
        const category =await  Category.findById(id);
        if(!category){
            return res.status(404).json({message:"category not font "})
        }
        
        const products = await Product.find({ category: id });
        return res.status(200).json(products);
    }catch(error){
        return res.status(500).json({message : error.message})
    }
}
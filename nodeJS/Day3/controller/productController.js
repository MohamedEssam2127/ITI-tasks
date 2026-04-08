import Product from '../models/productModel.js'
import Category from '../models/CategoryModel.js'



export const createProduct = async (req, res) => {
  try {
    const { name, price ,category} = req.body;
    
    if (!name || !price || !category) {
        return res.status(400).json({message: "name and price are required"});
    }

    const isExist = await Category.findById(category);
    if (!isExist) {
      return res.status(404).json({ message: "Category not found" });
    }

    const product = await Product.create({name,price ,category});
    return res.status(201).json({message: "Product created successfully",data: product,});
  } catch (error) {
    return res.status(500).json({message: error.message,});
  }
};

export const getAllProducts = async (req , res ) => {
    try{
        const porducts  = await Product.find();
        res.status(200).json({data:porducts});
    }catch (error){
        return res.status(500).json({message : error.message})
    }
}
export const 	getProductbyID  = async (req , res ) => {
    try{
        const {id}= req.params;
        const porduct  = await Product.findById(id).populate("category");
        if(!porduct)
          return  res.status(404).json({message:"product Not found "})
        res.status(200).json({data:porduct});
    }catch (error){
        return res.status(500).json({message : error.message})
    }
}

export const deleteById = async (req, res) => {
  try {
    const { id } = req.params;
    const deletedProduct = await Product.findByIdAndDelete(id);
    if (!deletedProduct) {
      return res.status(404).json({message: "Product not found"});
    }
    return res.status(200).json({message: "Product deleted successfully",data: deletedProduct,});
  } catch (error) {
    return res.status(500).json({message: error.message,});
  }
};

export const updateById = async (req, res) => {
  try {
    const { id } = req.params;
    const { name, price } = req.body;
    const updatedProduct = await Product.findByIdAndUpdate(id,{ name, price }, { returnDocument: "after" });
    if (!updatedProduct) {
      return res.status(404).json({message: "Product not found",});
    }
    return res.status(200).json({message: "Product updated successfully",data: updatedProduct,});
  } catch (error) {
    return res.status(500).json({message: error.message});
  }
};
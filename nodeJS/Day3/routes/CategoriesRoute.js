import express from "express";
import {createCategory , getAllCategories ,getAllProductsUnderaCategory } from"../controller/categoryController.js";


// Categories	POST	/categories	Create a new category
// Categories	GET	/categories	Get all categories
// Categories	GET	/categories/:id/products	Get all products under category

const router = express.Router();

router.post('/',createCategory);
router.get('/',getAllCategories);
router.get('/:id/products',getAllProductsUnderaCategory);
export default router;
import express from "express";
import { createProduct ,getAllProducts ,deleteById ,updateById} from "../controller/productController.js";

const router = express.Router();

router.post("/",createProduct)
router.get("/",getAllProducts);
router.delete("/:id", deleteById)
router.put("/:id", updateById)

export default router;
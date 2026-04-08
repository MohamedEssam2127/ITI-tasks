import express from "express";
import { createProduct ,getAllProducts ,deleteById ,updateById,getProductbyID} from "../controller/productController.js";
import { auth } from "../middleware/auth.js";
import { authorize } from "../middleware/authorization.js";
const router = express.Router();

router.post("/",createProduct)
router.get("/",auth,authorize("admin"),getAllProducts);
router.delete("/:id", deleteById)
router.put("/:id", updateById)
router.get("/:id" ,getProductbyID);
export default router;
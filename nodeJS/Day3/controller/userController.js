import User from "../models/userModel.js";
import jwt from "jsonwebtoken";

const genToken = (user) => {
  return jwt.sign(
    {
      id: user._id,
      email: user.email,
      role: user.role,
      username: user.username,
    },
    process.env.JWT_SECRET,
    {
      expiresIn: process.env.JWT_EXPIRES_IN,
    }
  );
};

const createError = (status, msg) => {
  const err = new Error(msg);
  err.status = status;
  return err;
};

export const register = async (req, res) => {
  const { email, password ,username,role} = req.body;
  const exists = await User.findOne({ email });
  if (exists) {
    throw createError(409, "already have account");
  }
  const user = await User.create({ email, password,role ,username  });
  const token = genToken(user);
  res.status(201).json({ user, token,role, success: true });
};


export const login = async (req, res) => {
  const { email, password } = req.body;
  const user = await User.findOne({ email });
  if (!user) {
    throw createError(401, "invalid email or password");
  }
  const isMatch = await user.comparePassword(password);
  if (!isMatch) {
    throw createError(401, "invalid email or password");
  }
  const token = genToken(user);
  res.json({ user, token, message: "login successed" });
};

export const profile =(req,res)=>{
    if(req.user.role==="admin"){
    res.json({message:"welcome from admin profile",user:req.user})

    }else
    res.json({message:"welcome from profile",user:req.user})
}

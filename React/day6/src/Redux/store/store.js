import { configureStore } from "@reduxjs/toolkit";
import NewsReducer from '../slices/newsSlice'

export const storeConfig = configureStore({
  reducer:{
    newsR: NewsReducer
  }
})

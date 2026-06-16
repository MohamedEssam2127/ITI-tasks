import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

const API_URL = 'http://localhost:3000/card';

export const getNewsAction = createAsyncThunk('news/getNews', async () => {
  const res = await axios.get(API_URL);
  return res.data;
});

export const addNewsAction = createAsyncThunk('news/addNews', async (newCard) => {
  const res = await axios.post(API_URL, newCard);
  return res.data;
});

const newsSlice = createSlice({
  name: 'news',
  initialState: {
    cards: [],
    allCards: [], 
    loading: false,
    error: null
  },
  reducers: {
    filterNews: (state, action) => {
      const searchTerm = action.payload.trim().toLowerCase();

      if (!searchTerm) {
        state.cards = state.allCards;
        return;
      }

      state.cards = state.allCards.filter((card) => {
        const searchableText = [
          card.title,
          card.titleAr,
          card.category,
          card.categoryAr,
          card.description,
          card.descriptionAr
        ]
          .filter(Boolean)
          .join(" ")
          .toLowerCase();

        return searchableText.includes(searchTerm);
      });
    }
  },
  extraReducers: (builder) => {

    builder.addCase(getNewsAction.pending, (state) => {
      state.loading = true;
    });
    builder.addCase(getNewsAction.fulfilled, (state, action) => {
      state.loading = false;
      state.cards = action.payload;
      state.allCards = action.payload; 
    });
    builder.addCase(getNewsAction.rejected, (state, action) => {
      state.loading = false;
      state.error = action.error.message;
    });

   
    builder.addCase(addNewsAction.fulfilled, (state, action) => {
      state.cards.push(action.payload);
    });
  }
});

export const { filterNews } = newsSlice.actions;
export default newsSlice.reducer;

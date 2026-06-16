
import i18n from "i18next";
import { initReactI18next } from "react-i18next";

import navEng from './localization/en/navBar.json';
import loginEng from './localization/en/Login.json';
import signupEng from './localization/en/SignUp.json';
import addNewsEng from './localization/en/addNews.json';
import listCardsEng from './localization/en/ListCards.json';
import cardEng from './localization/en/Card.json';
import newsDetailsEng from './localization/en/NewsDetails.json';

import navAr from './localization/ar/navBar.json';
import loginAr from './localization/ar/Login.json';
import signupAr from './localization/ar/SignUp.json';
import addNewsAr from './localization/ar/addNews.json';
import listCardsAr from './localization/ar/ListCards.json';
import cardAr from './localization/ar/Card.json';
import newsDetailsAr from './localization/ar/NewsDetails.json';

i18n
  .use(initReactI18next)
  .init({
    resources: {
      en: {
        navBar: navEng,
        Login: loginEng,
        SignUp: signupEng,
        addNews: addNewsEng,
        ListCards: listCardsEng,
        Card: cardEng,
        NewsDetails: newsDetailsEng
      },
      ar: {
        navBar: navAr,
        Login: loginAr,
        SignUp: signupAr,
        addNews: addNewsAr,
        ListCards: listCardsAr,
        Card: cardAr,
        NewsDetails: newsDetailsAr
      }
    },
    lng: "en", 
    fallbackLng: "en",

    interpolation: {
      escapeValue: false
    }
  });




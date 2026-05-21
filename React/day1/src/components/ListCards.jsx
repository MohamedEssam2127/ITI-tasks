import '../styles/ListCards.css'
import {  useState } from "react"
import Card from "./Card"

import DB from '../../db.json'
export function ListCards () {
    const [state] = useState({ cards :DB.card})
  
  return (
   <div className="news-list-section">
     <h3 className="section-title">Latest News</h3>
     
     {state.cards.map((news) => (
  <Card key={news.id} {...news} />
))}
   </div>
  )
    }

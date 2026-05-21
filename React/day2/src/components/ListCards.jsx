import '../styles/ListCards.css'
import { Component } from "react"
import Card from "./Card"
// import axios from 'axios'
import DB from '../../db.json'
export class ListCards extends Component {
    // const [cards] = useState([1,2,3])
    state ={ cards :DB.card}
    render(){
  return (
   <div className="news-list-section">
     <h3 className="section-title">Latest News</h3>
     
     {this.state.cards.map((news) => (
  <Card key={news.id} {...news} />
))}
   </div>
  )
    }


    // componentDidMount(){
    //     axios.get("http://localhost:3000/card").then((res) => {
    //   console.log(res);
    // });
    // }
}

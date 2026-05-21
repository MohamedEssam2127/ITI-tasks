
import { Component } from 'react'
import '../styles/Card.css'

class Card extends Component{



  render(){

 return (
    <article className="custom-card">
      <div className="card-image-wrapper">
        <img 
          src= {this.props.img} 
          className="card-image" 
        />
      </div>

      <div className="card-content">
        <div className="card-header">
          <span className="card-badge">{this.props.category}</span>
          <time className="card-time">{this.props.time}</time>
        </div>

        <h4 className="card-title">
          {this.props.title}
        </h4>
        
        <p className="card-text">
          {this.props.description}
        </p>

        <div className="card-footer">
          <a href="#" className="read-more">Read more</a>
        </div>
      </div>
    </article>
  )
  }
 
}

export default Card
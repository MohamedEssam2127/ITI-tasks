

import '../styles/Card.css'

function Card (props) {



  

 return (
    <article className="custom-card">
      <div className="card-image-wrapper">
        <img 
          src= {props.img} 
          className="card-image" 
        />
      </div>

      <div className="card-content">
        <div className="card-header">
          <span className="card-badge">{props.category}</span>
          <time className="card-time">{props.time}</time>
        </div>

        <h4 className="card-title">
          {props.title}
        </h4>
        
        <p className="card-text">
          {props.description}
        </p>

        <div className="card-footer">
          <a href="#" className="read-more">Read more</a>
        </div>
      </div>
    </article>
  )
  }
 


export default Card
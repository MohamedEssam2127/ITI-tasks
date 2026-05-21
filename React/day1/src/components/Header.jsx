import '../styles/Header.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import {  faBell, faUserCircle } from '@fortawesome/free-solid-svg-icons'

export default function Header () {







  return (
    <header className="custom-header">
      <div className="header-container">
        
        <div>
          <a className="header-brand" href="#">TechPulse</a>
        </div>
          
        <nav className="header-nav">
          <a className="nav-link active" href="#">Home</a>
          <a className="nav-link" href="#">Latest</a>
          <a className="nav-link" href="#">Categories</a>
        </nav>

        <div className="header-actions">
          <button className="btn-primary">
            Add News
          </button>

          <div className="header-icons">
            <FontAwesomeIcon icon={faBell} />
            <FontAwesomeIcon icon={faUserCircle} />
          </div>
        </div>

      </div>
    </header>
  )
  }

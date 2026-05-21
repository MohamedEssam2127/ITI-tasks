import { Component } from 'react';
import '../styles/Footer.css'

class  Footer extends Component{

  render(){
return (
    <footer className="custom-footer">
      <h5 className="footer-brand">TechPulse</h5>
      <p className="footer-text">&copy; {new Date().getFullYear()} TechPulse. All rights reserved.</p>
    </footer>
  );
  }
  
};

export default Footer;
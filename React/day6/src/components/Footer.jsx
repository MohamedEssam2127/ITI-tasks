import styles from '../styles/Footer.module.css'

function  Footer() {

    return (
    <footer className={styles['custom-footer']}>
      <h5 className={styles['footer-brand']}>TechPulse</h5>
      <p className={styles['footer-text']}>&copy; 2026 TechPulse</p>
    </footer>
  );
  }
  


export default Footer;
import styles from '../styles/Header.module.css'
import { Link, useLocation, useNavigate } from 'react-router'
import { useTranslation } from 'react-i18next'
import { FaGlobe, FaSun, FaMoon } from 'react-icons/fa'
import { useEffect, useState } from 'react'

export default function Header() {
  const { t, i18n } = useTranslation('navBar');
  const navigate = useNavigate()
  const location = useLocation()
  const [isAuthenticated, setIsAuthenticated] = useState(Boolean(localStorage.getItem('user')))
  
  const [isDark, setIsDark] = useState(() => {
    return document.documentElement.getAttribute('data-theme') === 'dark'
  });

  const toggleLanguage = () => {
    const newLang = i18n.language === 'en' ? 'ar' : 'en';
    i18n.changeLanguage(newLang);
  }

  const toggleTheme = () => {
    const newTheme = isDark ? 'light' : 'dark';
    setIsDark(!isDark);
    document.documentElement.setAttribute('data-theme', newTheme);
  }

  useEffect(() => {
    document.documentElement.dir = i18n.language === 'ar' ? 'rtl' : 'ltr';
  }, [i18n.language]);

  const handleLogout = () => {
    localStorage.removeItem('user')
    setIsAuthenticated(false)
    navigate('/login', { replace: true })
  }

  useEffect(() => {
    const handleStorage = () => setIsAuthenticated(Boolean(localStorage.getItem('user')))
    window.addEventListener('storage', handleStorage)
    return () => window.removeEventListener('storage', handleStorage)
  }, [])

  useEffect(() => {
    setIsAuthenticated(Boolean(localStorage.getItem('user')))
  }, [location.pathname])

  return (
    <header className={styles['custom-header']}>
      <div className={styles['header-container']}>
        <div>
          <Link className={styles['header-brand']} to='/'>{t('brand')}</Link>
        </div>

        <div className={styles['header-actions']}>
          <button 
            className={styles['btn-primary']} 
            onClick={toggleTheme}
            style={{ display: 'flex', alignItems: 'center', justifyContent: 'center', width: '36px', height: '36px', background: 'transparent', color: 'inherit', border: '1px solid #ccc', borderRadius: '50%', padding: '0' }}
            title={isDark ? "Switch to Light Mode" : "Switch to Dark Mode"}
          >
            {isDark ? <FaSun size={18} /> : <FaMoon size={18} />}
          </button>
          
          <button 
            className={styles['btn-primary']} 
            onClick={toggleLanguage}
            style={{ display: 'flex', alignItems: 'center', gap: '0.5rem', background: 'transparent', color: 'inherit', border: '1px solid #ccc' }}
          >
            <FaGlobe /> {i18n.language === 'en' ? 'عربي' : 'English'}
          </button>

          {isAuthenticated ? (
            <>
              <Link to='addNews'>
                <button className={styles['btn-primary']}>
                  {t('addNews')}
                </button>
              </Link>
              <button className={styles['btn-logout']} onClick={handleLogout}>
                {t('logout')}
              </button>
            </>
          ) : (
            <>
              <Link to='login'>
                <button className={styles['btn-primary']}>
                  {t('login')}
                </button>
              </Link>
              <Link to='signup'>
                <button className={styles['btn-primary']}>
                  {t('register')}
                </button>
              </Link>
            </>
          )}
        </div>
      </div>
    </header>
  )
}



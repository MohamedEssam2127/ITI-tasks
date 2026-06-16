
import { useState } from 'react'
import { useNavigate, Link } from 'react-router'
import styles from '../styles/Auth.module.css'
import axios from 'axios'
import toast from 'react-hot-toast'
import { useTranslation } from 'react-i18next'
import { HiOutlineMail, HiOutlineLockClosed, HiOutlineLogin } from 'react-icons/hi'

export const Login = () => {
  const [inputData, setInputData] = useState({
    email: '',
    password: ''
  })

  const [error, setError] = useState('')
  const navigate = useNavigate()
  const { t } = useTranslation('Login')

  const handleChg = (e) => {
    setInputData({...inputData,[e.target.name]: e.target.value})
  }

  const handleSubmit = (e) => {
    e.preventDefault()
    setError('')

    if (!inputData.email || !inputData.password) {
      setError(t('fillAllFields'))
      return
    }
    axios.get('http://localhost:3000/users')
      .then(response => {
        const users = response.data
        const user = users.find(u => u.email === inputData.email && u.password === inputData.password)
        if (user) {
          localStorage.setItem('user', JSON.stringify({
            username: user.username,
            email: user.email
          }))
          toast.success(t('loginSuccess'))
          navigate('/home', { replace: true })
        } else {
          setError(t('invalidCredentials'))
        }
      })
      .catch(error => {
        console.error('error during login:', error)
        setError(t('loginFailed'))
      })
  }

  return (
    <div className={styles['auth-page']}>
      <div className={styles['auth-card']}>
        {/* Brand area */}
        <div className={styles['auth-brand']}>
          <div className={styles['auth-logo']}>
            <HiOutlineLogin size={28} />
          </div>
          <h1 className={styles['auth-title']}>{t('loginTitle')}</h1>
          <p className={styles['auth-subtitle']}>Sign in to continue to your account</p>
        </div>

        <form onSubmit={handleSubmit}>
          {/* Email */}
          <div className={styles['form-group']}>
            <label className={styles['form-label']}>{t('emailLabel')}</label>
            <div className={styles['input-wrapper']}>
              <input
                type="email"
                className={styles['auth-input']}
                placeholder={t('emailPlaceholder')}
                name="email"
                value={inputData.email}
                onChange={handleChg}
              />
              <span className={styles['input-icon']}><HiOutlineMail size={18} /></span>
            </div>
          </div>

          {/* Password */}
          <div className={styles['form-group']}>
            <label className={styles['form-label']}>{t('passwordLabel')}</label>
            <div className={styles['input-wrapper']}>
              <input
                type="password"
                className={styles['auth-input']}
                placeholder={t('passwordPlaceholder')}
                name="password"
                value={inputData.password}
                onChange={handleChg}
              />
              <span className={styles['input-icon']}><HiOutlineLockClosed size={18} /></span>
            </div>
          </div>

          {/* Error */}
          {error && <p className={styles['error-message']}>{error}</p>}

          {/* Submit */}
          <button className={styles['auth-btn']} type="submit">
            {t('loginButton')}
          </button>
        </form>

        {/* Footer link */}
        <p className={styles['auth-footer']}>
          {t('noAccount')} <Link to="/signup">{t('signUpLink')}</Link>
        </p>
      </div>
    </div>
  )
}



import { useState } from 'react'
import { useNavigate, Link } from 'react-router'
import styles from '../styles/Auth.module.css'
import toast from 'react-hot-toast'
import axios from 'axios'
import { useTranslation } from 'react-i18next'
import { HiOutlineMail, HiOutlineLockClosed, HiOutlineUserAdd, HiOutlineUser } from 'react-icons/hi'

export const SignUp = () => {
  const [inputData, setInputData] = useState({
    username: '',
    email: '',
    password: ''
  })
  const [error, setError] = useState('')
  const navigate = useNavigate()
  const { t } = useTranslation('SignUp')

  const handleChg = (e) => {
    setInputData({
      ...inputData,
      [e.target.name]: e.target.value
    })
  }

  const handleSubmit = (e) => {
    e.preventDefault()
    setError('')

    if (!inputData.username || !inputData.email || !inputData.password) {
      setError(t('fillAllFields'))
      return
    }

        axios.post('http://localhost:3000/users', inputData)
     .then()
      .catch(error => {
        console.error('Error registering user:', error)
      })
    localStorage.setItem('registeredUser', JSON.stringify(inputData))
    localStorage.setItem('user', JSON.stringify({
      username: inputData.username,
      email: inputData.email
    }))



    toast.success(t('registerSuccess'))
    navigate('/home', { replace: true })
  }

  return (
    <div className={styles['auth-page']}>
      <div className={styles['auth-card']}>
        {/* Brand area */}
        <div className={styles['auth-brand']}>
          <div className={styles['auth-logo']}>
            <HiOutlineUserAdd size={28} />
          </div>
          <h1 className={styles['auth-title']}>{t('signUpTitle')}</h1>
          <p className={styles['auth-subtitle']}>Create your account to get started</p>
        </div>

        <form onSubmit={handleSubmit}>
          {/* Username */}
          <div className={styles['form-group']}>
            <label className={styles['form-label']}>{t('usernameLabel')}</label>
            <div className={styles['input-wrapper']}>
              <input
                type="text"
                className={styles['auth-input']}
                placeholder={t('usernamePlaceholder')}
                name="username"
                value={inputData.username}
                onChange={handleChg}
              />
              <span className={styles['input-icon']}><HiOutlineUser size={18} /></span>
            </div>
          </div>

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
            {t('signUpButton')}
          </button>
        </form>

        {/* Footer link */}
        <p className={styles['auth-footer']}>
          {t('alreadyAccount')} <Link to="/login">{t('loginLink')}</Link>
        </p>
      </div>
    </div>
  )
}


import { useState } from 'react'
import styles from '../styles/InputForm.module.css'
import { v4 as uuidv4 } from 'uuid'
import toast from 'react-hot-toast'
import { useTranslation } from 'react-i18next'

import { useDispatch } from 'react-redux'
import { addNewsAction } from '../Redux/slices/newsSlice'

export function InputForm() {
  const dispatch = useDispatch()
  const defaultImg = 'https://via.placeholder.com/600x400?text=News+Image'
  const [inputData, setInputData] = useState({
    title: '',
    category: '',
    imgUrl: '',
    description: ''
  })
  const { t } = useTranslation('addNews')

  const handleChg = (e) => {
    setInputData({
      ...inputData,
      [e.target.name]: e.target.value
    })
  }

  const addPost = async (e) => {
    e.preventDefault()
    try {
      const dataWithId = {
        ...inputData,
        id: uuidv4(),
        imgUrl: inputData.imgUrl?.trim() || defaultImg
      }
      
      await dispatch(addNewsAction(dataWithId)).unwrap()
      toast.success(t('addSuccess'))

      setInputData({
        title: '',
        category: '',
        imgUrl: '',
        description: ''
      })
    } catch (error) {
      console.error('Error adding post:', error)
      toast.error(t('addFailed'))
    }
  }

  return (
    <section className={styles['news-form-section']}>
      <h3 className="section-title" style={{ visibility: "hidden" }}>Spacer</h3>
      <form className={styles['custom-form']} onSubmit={addPost}>
        <h3 className="section-title">{t('formTitle')}</h3>

        <div className={styles['form-row']}>
          <div className={styles['form-group']}>
            <label className={styles['form-label']}>{t('titleLabel')}</label>
            <input type="text" className={styles['custom-input']} placeholder={t('titlePlaceholder')}
              name='title' value={inputData.title} onChange={handleChg} />
          </div>

          <div className={styles['form-group']}>
            <label className={styles['form-label']}>{t('categoryLabel')}</label>
            <input type="text" className={styles['custom-input']} placeholder={t('categoryPlaceholder')} name='category'
              value={inputData.category} onChange={handleChg} />
          </div>
        </div>

        <div className={styles['form-group']}>
          <label className={styles['form-label']}>{t('imgUrlLabel')}</label>
          <input type="text" className={styles['custom-input']} placeholder={t('imgUrlPlaceholder')}
            name='imgUrl' value={inputData.imgUrl} onChange={handleChg} />
        </div>

        <div className={styles.previewWrapper}>
          <p className={styles.previewLabel}>{t('imgUrlLabel')}</p>
          <img
            src={inputData.imgUrl?.trim() || defaultImg}
            alt="News preview"
            className={styles.previewImage}
            onError={(e) => {
              e.currentTarget.src = defaultImg
            }}
          />
        </div>
        <div className={styles['form-group']}>
          <label className={styles['form-label']}>{t('descriptionLabel')}</label>
          <textarea className={`${styles['custom-input']} ${styles['no-resize']}`} rows="5" placeholder={t('descriptionPlaceholder')}
            name='description' value={inputData.description} onChange={handleChg}></textarea>
        </div>

        <button className={styles['btn-primary']} type="submit">
          {t('publishButton')}
        </button>
      </form>
    </section>
  )
}
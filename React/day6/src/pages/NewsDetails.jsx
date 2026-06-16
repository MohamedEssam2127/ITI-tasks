
import { useEffect, useState } from 'react'
import { useNavigate, useParams } from 'react-router'
import axios from 'axios'
import { useSelector } from 'react-redux'
import styles from '../styles/NewsDetails.module.css'
import { useTranslation } from 'react-i18next'
import { HiOutlineArrowLeft, HiOutlineClock, HiOutlineTag } from 'react-icons/hi'

export const NewsDetails = () => {
  const { id } = useParams()
  const navigate = useNavigate()
  const { cards } = useSelector((state) => state.newsR)
  const [newsItem, setNewsItem] = useState(null)
  const [loading, setLoading] = useState(true)
  const { t, i18n } = useTranslation('NewsDetails')
  const isAr = i18n.language === 'ar'

  useEffect(() => {
    const found = cards.find((item) => item.id === id)
    if (found) {
      setNewsItem(found)
      setLoading(false)
      return
    }

    axios.get(`http://localhost:3000/card/${id}`)
      .then((response) => {
        setNewsItem(response.data)
      })
      .catch((error) => {
        console.error('Error loading news details:', error)
        setNewsItem(null)
      })
      .finally(() => {
        setLoading(false)
      })
  }, [cards, id])

  if (loading) {
    return (
      <section className={styles.loadingSection}>
        <div className={styles.spinner}></div>
        <p>{t('loading')}</p>
      </section>
    )
  }

  if (!newsItem) {
    return (
      <section className={styles.notFoundSection}>
        <p>{t('notFound')}</p>
        <button className={styles.backButton} onClick={() => navigate('/home')}>
          <HiOutlineArrowLeft size={16} />
          {t('goBack')}
        </button>
      </section>
    )
  }

  return (
    <section className={styles.detailsSection}>
      <button className={styles.backButton} onClick={() => navigate('/home')}>
        <HiOutlineArrowLeft size={16} />
        {t('backToHome')}
      </button>
      <div className={styles.detailsCard}>
        <div className={styles.imageWrapper}>
          <img
            src={newsItem.imgUrl}
            alt={newsItem.title}
            className={styles.detailsImage}
          />
        </div>
        <div className={styles.detailsContent}>
          <span className={styles.detailsCategory}>
            <HiOutlineTag size={14} />
            {isAr ? newsItem.categoryAr || newsItem.category : newsItem.category}
          </span>
          <h2 className={styles.detailsTitle}>{isAr ? newsItem.titleAr || newsItem.title : newsItem.title}</h2>
          {newsItem.time && (
            <time className={styles.detailsTime}>
              <HiOutlineClock size={15} />
              {isAr ? newsItem.timeAr || newsItem.time : newsItem.time}
            </time>
          )}
          <div className={styles.divider}></div>
          <p className={styles.detailsDescription}>{isAr ? newsItem.descriptionAr || newsItem.description : newsItem.description}</p>
        </div>
      </div>
    </section>
  )
}


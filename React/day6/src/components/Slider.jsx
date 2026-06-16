import { useEffect, useMemo, useState } from 'react'
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faArrowLeft, faArrowRight } from "@fortawesome/free-solid-svg-icons";
import styles from '../styles/slider.module.css'
import { Link } from 'react-router';
import { useSelector } from 'react-redux';
import { useTranslation } from 'react-i18next';

export default function Slider() {
  const { cards } = useSelector((state) => state.newsR)
  const { i18n } = useTranslation()
  const isAr = i18n.language === 'ar'

  const featuredNews = useMemo(() => cards?.slice(0, 5) ?? [], [cards])
  const [currentIndex, setCurrentIndex] = useState(0)

  useEffect(() => {
    if (!featuredNews.length) return undefined

    const timer = setInterval(() => {
      setCurrentIndex((prev) => (prev === featuredNews.length - 1 ? 0 : prev + 1))
    }, 4500)

    return () => clearInterval(timer)
  }, [featuredNews.length])

  useEffect(() => {
    if (currentIndex >= featuredNews.length && featuredNews.length > 0) {
      setCurrentIndex(0)
    }
  }, [currentIndex, featuredNews.length])

  const left = () => {
    setCurrentIndex((prev) => (prev === 0 ? featuredNews.length - 1 : prev - 1))
  }

  const right = () => {
    setCurrentIndex((prev) => (prev === featuredNews.length - 1 ? 0 : prev + 1))
  }

  const goToIndex = (index) => {
    setCurrentIndex(index)
  }

  if (!featuredNews.length) return null

  const currentNews = featuredNews[currentIndex]

  return (
    <div className={styles.parentWrapper}>
      <div className={styles['slider-container']}>
        <div className={styles['slider-image-wrapper']}>
          <button className={`${styles['slider-arrow']} ${styles.left}`} onClick={left}>
            <FontAwesomeIcon icon={faArrowLeft} />
          </button>

          <img
            key={currentIndex}
            src={currentNews.imgUrl}
            className={styles['slider-img']}
            alt={currentNews.title}
          />

          <button className={`${styles['slider-arrow']} ${styles.right}`} onClick={right}>
            <FontAwesomeIcon icon={faArrowRight} />
          </button>

          <div className={styles.overlay}>
            <span className={styles.badge}>{isAr ? currentNews.categoryAr || currentNews.category : currentNews.category}</span>
            <h2 className={styles.overlayTitle}>{isAr ? currentNews.titleAr || currentNews.title : currentNews.title}</h2>
            <p className={styles.overlayDescription}>
              {isAr ? currentNews.descriptionAr || currentNews.description : currentNews.description}
            </p>
            <Link to={`/detailsusers/${currentNews.id}`} className={styles.overlayBtn}>
              {isAr ? 'اقرأ التفاصيل' : 'Read Full Story'}
            </Link>
          </div>
        </div>
      </div>

      <div className={styles['circle-container']}>
        {featuredNews.map((_, index) => (
          <div
            key={index}
            className={`${styles.circle} ${index === currentIndex ? styles.active : ''}`}
            onClick={() => goToIndex(index)}
          ></div>
        ))}
      </div>
    </div>
  )
}
import { useState } from 'react'
import { Link } from 'react-router'
import styles from '../styles/Card.module.css'
import { LikeBTN } from './LikeBTN.jsx'
import { faCircleUp, faCircleDown } from '@fortawesome/free-solid-svg-icons'
import { useTranslation } from 'react-i18next'

function Card(props) {
  const { t, i18n } = useTranslation('Card')
  const isAr = i18n.language === 'ar'
  const [counter, setCounter] = useState(0)
  const handleIncrement = (e) => {
    e.preventDefault()
    e.stopPropagation()
    setCounter(counter + 1)
  }
  const handleDecrement = (e) => {
    e.preventDefault()
    e.stopPropagation()
    setCounter(counter === 0 ? counter : counter - 1)
  }

  return (
    <Link
      to={`/detailsusers/${props.id}`}
      style={{ textDecoration: 'none', color: 'inherit' }}
    >
      <div className={styles.customCard}>
        <div className={styles.cardImageWrapper}>
          <span className={styles.cardBadge}>{isAr ? props.categoryAr || props.category : props.category}</span>
          <img
            src={props.imgUrl}
            className={styles.cardImage}
            alt={props.title}
          />
        </div>

        <div className={styles.cardContent}>
          <div className={styles.cardHeader}>
            <time className={styles.cardTime}>{isAr ? props.timeAr || props.time : props.time}</time>
          </div>

          <h4 className={styles.cardTitle}>
            {isAr ? props.titleAr || props.title : props.title}
          </h4>

          <p className={styles.cardText}>
            {isAr ? props.descriptionAr || props.description : props.description}
          </p>

          <div className={styles.cardFooter}>
            <div className={styles.likeActions}>
              <div className={styles.likeBtns}>
                <LikeBTN icon={faCircleUp} type="like" handleClick={handleIncrement} />
                <LikeBTN icon={faCircleDown} type="dislike" handleClick={handleDecrement} />
              </div>
              <div className={styles.counterDisplay}>
                {counter} {t('likes')}
              </div>
            </div>
            <span className={styles.readMore}>{t('readMore')}</span>
          </div>
        </div>
      </div>
    </Link>
  )
}

export default Card
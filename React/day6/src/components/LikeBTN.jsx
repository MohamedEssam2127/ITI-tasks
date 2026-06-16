import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import styles from '../styles/Card.module.css'

export const LikeBTN = ({ icon, handleClick, type }) => {
  const btnClass = type === 'like' ? styles.likeBtn : styles.dislikeBtn
  return (
    <button type="button" className={`${styles.baseLikeBtn} ${btnClass}`} onClick={(e) => handleClick(e)}>
      <FontAwesomeIcon icon={icon} />
    </button>
  )
}

import { useSelector } from 'react-redux'
import styles from '../styles/ListCards.module.css'

import Card from "./Card"
import { useTranslation } from 'react-i18next'

export function ListCards() {
  const { cards, loading, error } = useSelector((state) => state.newsR);
  const { t } = useTranslation('ListCards');

  if (loading) return <div className={styles.loadingState}>Loading news...</div>;
  if (error) return <div className={styles.errorState}>Error: {error}</div>;
  if (!cards?.length) return <div className={styles.emptyState}>{t('latestNews')}: 0</div>;

  return (
    <div className={styles.newsListSection}>
      <h3 className="section-title">{t('latestNews')}</h3>
      <div className={styles.cardsGrid}>
        {cards?.map((news) => (
          <Card key={news.id} {...news} />
        ))}
      </div>
    </div>
  )
}

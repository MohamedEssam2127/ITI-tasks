import { FaSearch } from "react-icons/fa"
import styles from '../styles/Search.module.css'
import { useState } from "react"
import { useDispatch } from "react-redux"
import { filterNews } from "../Redux/slices/newsSlice"
import { useTranslation } from "react-i18next"

export const Search = () => {
  const dispatch = useDispatch()
  const [inputValue, setInputValue] = useState("")
  const { i18n } = useTranslation()

  const handleOnChange = (e) => {
    setInputValue(e.target.value)
    dispatch(filterNews(e.target.value))
  }
  return (
    <div className={styles.Search_container}>
      <FaSearch />
      <input
        type="text"
        value={inputValue}
        onChange={handleOnChange}
        placeholder={i18n.language === "ar" ? "ابحث في الأخبار..." : "Search news by title, category, or topic..."}
        aria-label={i18n.language === "ar" ? "بحث الأخبار" : "Search news"}
      />
    </div>
  )
}

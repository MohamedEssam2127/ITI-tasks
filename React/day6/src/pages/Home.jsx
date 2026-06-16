import { useEffect } from "react"
import { useDispatch, useSelector } from "react-redux"
import { ListCards } from "../components/ListCards"
import { Search } from "../components/Search"
import Slider from "../components/Slider"
import { getNewsAction } from "../Redux/slices/newsSlice"

export const Home = () => {
  const dispatch = useDispatch()
  const { cards } = useSelector((state) => state.newsR)

  useEffect(() => {
    if (!cards?.length) {
      dispatch(getNewsAction())
    }
  }, [cards?.length, dispatch])

  return (
    <main style={{ background: 'var(--bg-color)', minHeight: '100vh' }}>
      <Slider />
      <Search />
      <ListCards />
    </main>
  )
}


import './styles/App.css'
import Header from './components/Header'
import { InputForm } from './components/InputForm'
import { ListCards } from './components/ListCards'
import Footer from './components/Footer'

function App() {
 

  return (
    <>
      <Header/>
      <div className="app-container">
        <div className="app-layout">
           <InputForm/>
           <div className='app-right-side'>
            <ListCards/>
           </div>
         
         
        </div>
      </div>
      <Footer/>
    </>
  )
}

export default App

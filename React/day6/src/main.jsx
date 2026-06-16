
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'

import './i18n.js';
import { Provider } from 'react-redux'
import { storeConfig } from './Redux/store/store.js'

createRoot(document.getElementById('root')).render(
  // <StrictMode>
    <Provider store={storeConfig}>
      <App />
    </Provider>
  // </StrictMode>,
)

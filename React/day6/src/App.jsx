import { createBrowserRouter, Navigate, RouterProvider } from 'react-router'
import { Layout } from './pages/Layout'
import { Home } from './pages/Home'
import { Login } from './pages/LogIn'
import { SignUp } from './pages/SignUp'
import { AddNews } from './pages/AddNews'
import { NotFound } from './pages/NotFound'
import { NewsDetails } from './pages/NewsDetails'
import { Toaster } from 'react-hot-toast'

const ProtectedRoute = ({ children }) => {
  if (typeof window !== 'undefined' && !localStorage.getItem('user')) {
    return <Navigate to="/login" replace />
  }
  return children
}

function App() {
  const routerCofig = createBrowserRouter([
    {
      element: <Layout />,
      children: [
        { index: true, element: <Navigate to="home" replace /> },
        { path: "home", element: <ProtectedRoute><Home /></ProtectedRoute> },
        { path: 'addNews', element: <ProtectedRoute><AddNews /></ProtectedRoute> },
        { path: 'detailsusers/:id', element: <ProtectedRoute><NewsDetails /></ProtectedRoute> },
      ]
    },
    { element: <Login />, path: 'login' },
    { element: <SignUp />, path: 'signup' },
    { element: <NotFound />, path: "*" }
  ]);


  return (
    <>
      <Toaster />
      <RouterProvider router={routerCofig}></RouterProvider>
    </>
  )
}

export default App
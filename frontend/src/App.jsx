import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { Container } from 'react-bootstrap'
import NavBarMarvel from './components/NavBarMarvel'
import { Route, Routes } from 'react-router-dom'
import { RouteNames } from './constants'
import IdentitetiPregled from './pages/Identiteti/IdentitetiPregled'

function App() {
  

  return (
    <>
     <Container>
      <NavBarMarvel />
      <Routes>
        <Route path={RouteNames.HOME} element={<Pocetna />} />
        <Route path={RouteNames.IDENTITET_PREGLED} element={<IdentitetiPregled/>}/>
      </Routes>
      <hr />
      &copy; Pamela 2025
     </Container>
    </>
  )
}

export default App

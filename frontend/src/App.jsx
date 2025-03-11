import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import { Container } from 'react-bootstrap'
import NavBarMarvel from './components/NavBarMarvel'
import { Route, Routes } from 'react-router-dom'
import { RouteNames } from './constants'
import IdentitetiPregled from './pages/Identiteti/IdentitetiPregled'
import IdentitetiPromjena from './pages/IdentitetiPromjena'
import HerojiPregled from './pages/Heroji/HerojiPregled'
import HerojiDodaj from './pages/Heroji/HerojiDodaj'
import HerojiPromjena from './pages/Heroji/HerojiPromjena'
import TimoviDodaj from './pages/Timovi/TimoviDodaj'
import TimoviPregled from './pages/Timovi/TimoviPregled'
import TimoviPromjena from './pages/Timovi/TimoviPromjena'

function App() {
  

  return (
    <>
     <Container>
      <NavBarMarvel />
      <Routes>
        <Route path={RouteNames.HOME} element={<Pocetna />} />
        <Route path={RouteNames.IDENTITET_PREGLED} element={<IdentitetiPregled/>}/>
        <Route path={RouteNames.IDENTETI_NOVI}element={<IdentitetiDodaj/>}/>
        <Route path={RouteNames.IDENTITET_PROMJENA}element={<IdentitetiPromjena/>}/>
        <Route path={RouteNames.HEROJI_PREGLED}element={<HerojiPregled/>}/>
        <Route path={RouteNames.HEROJI_DODAJ}element={<HerojiDodaj/>}/>
        <Route path={RouteNames.HEROJI_PROMJENA}element={<HerojiPromjena/>}/>
        <Route path={RouteNames.TIMOVI_PREGLED}element={<TimoviPregled/>} />
        <Route path={RouteNames.TIMOVI_DODAJ}element={<TimoviDodaj/>} />
        <Route path={RouteNames.TIMOVI_PROMJENA}element={<TimoviPromjena/>} />
      </Routes>
      <hr />
      &copy; Pamela 2025
     </Container>
    </>
  )
}

export default App

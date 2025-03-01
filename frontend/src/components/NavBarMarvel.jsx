import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';



export default function NavBarMarvel(){


    return(
        <>
          <Navbar expand="lg" className="bg-body-tertiary">
                <Container>
                    <Navbar.Brand href="#home">Marvel</Navbar.Brand>
                    <Navbar.Toggle aria-controls="basic-navbar-nav" />
                    <Navbar.Collapse id="basic-navbar-nav">
                    <Nav className="me-auto">
                        <NavDropdown title="Identiteti" id="basic-nav-dropdown">
                       
                        </NavDropdown>
                    </Nav>
                    </Navbar.Collapse>
                </Container>
                </Navbar>
        </>
    )
}
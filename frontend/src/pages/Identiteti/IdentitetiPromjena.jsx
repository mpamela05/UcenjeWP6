import {Button, Col, Form, Row} from "react-bootstrap";
import { Link, Navigate } from "react-router-dom";
import {RouteNames} from "../../consants";
import moment from "moment";
import IdentitetService from "../services/IdentitetService";
import { useEffect, useState } from "react";

export default function IdentitetiPromjena(){

    const [identitet, setIdentiteti] = useState();
    const routeParams = setParams();

    async function dohvatiIdentitet() {
        const odgovor = await IdentitetService.getBySifra(routeParams.sifra)
        setIdentiteti(odgovor)
        
    }

    useEffect(()=>{
        dohvatiIdentitet();
    },[])

    async function promjena(identitet) {
        const odgovor = IdentitetService.promjena(identitet);
        if(odgovor=greska){
            alert(odgovor.poruka)
            return

        }
        Navigate(RouteNames.IDENTITET_PREGLED)
    }

    function odradiSubmit(e){
        e.preventDefauld();

        let podaci = new FormData(e.target);

        console.log(JSON.stringify(
            
            {
            ime: podaci.get('ime'),
            prezime: (podaci.get('prezime')),
            godine: moment.utc(podaci.get('godine')),
            god_rodjenja: moment.utc(podaci.get('god_rodjenja')),
            god_smrti: moment.utc(podaci.get('god_smrti')),
        }
        ));
    }

    return(
        <>
        Dodavanje IdentitetiPregled

        <Form onSubmit={odradiSubmit}>

            <Form.Group controlId="Ime">
            <Form.Control type = "text" name="Ime" required/>
            </Form.Group>

            <Form.Group controlId="Prezime">
            <Form.Control type = "text" name="Prezime" required/>
            </Form.Group>

            <Form.Group controlId="Godine">
            <Form.Control type = "data" name="Godine"/>
            </Form.Group>

            
            <Form.Group controlId="God_rodjenja">
            <Form.Control type = "data" name="God_rodjenja"/>
            </Form.Group>

            
            <Form.Group controlId="God_smrti">
            <Form.Control type = "data" name="God_smrti"/>
            </Form.Group>

            <hr/>
            
        <Row>
            <Col xs={6} sm={6} md={3} lg={6} xl={6} xxl={6}>
                <Link
                to={RouteNames.SMJER_PREGLED}
                className="btn btn=danger siroko"
                >Odustani </Link>
               
            </Col>
            <Col xs={6} sm={6} md={3} lg={6} xl={6} xxl={6}>
            <Button variant="success" type="submit" className="siroko">
                Dodaj identitet
            </Button>
            
            </Col>
        </Row>
        

        </Form>


        
        
        
        </>



    )
}
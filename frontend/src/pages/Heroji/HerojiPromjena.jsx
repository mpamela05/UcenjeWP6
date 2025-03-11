import {Button, Col, Form, Row} from "react-bootstrap";
import { Link, Navigate } from "react-router-dom";
import {RouteNames} from "../../consants";
import moment from "moment";
import IdentitetService from "../services/IdentitetService";
import { useEffect, useState } from "react";

export default function HerojiPromjena(){

    const [identitet, setIdentiteti] = useState();
    const routeParams = setParams();

    async function dohvatiHeroji() {
        const odgovor = await HerojiService.getBySifra(routeParams.sifra)
        setHeroji(odgovor)
        
    }

    useEffect(()=>{
        dohvatiHeroji();
    },[])

    async function promjena(Heroji) {
        const odgovor = IHerojiService.promjena(Heroji);
        if(odgovor=greska){
            alert(odgovor.poruka)
            return

        }
        Navigate(RouteNames.HEROJI_PREGLED)
    }

    function odradiSubmit(e){
        e.preventDefauld();

        let podaci = new FormData(e.target);

        console.log(JSON.stringify(
            
            {
            ime: podaci.get('ime'),
            moc: (podaci.get('moc')),
            mjesto: (podaci.get('mjesto')),
            g_dolaska: moment.utc(podaci.get('g_dolaska')),
           
        }
        ));
    }

    return(
        <>
        Dodavanje HerojiPregled

        <Form onSubmit={odradiSubmit}>

            <Form.Group controlId="Ime">
            <Form.Control type = "text" name="Ime" required/>
            </Form.Group>

            <Form.Group controlId="Moc">
            <Form.Control type = "text" name="MOc" required/>
            </Form.Group>

            <Form.Group controlId="Mjesto">
          <Form.Control type = "text" name="Mjesto"/>
            </Form.Group>

            
            <Form.Group controlId="g_dolaska">
            <Form.Control type = "data" name="g_dolaska"/>
            </Form.Group>

            

            <hr/>
            
        <Row>
            <Col xs={6} sm={6} md={3} lg={6} xl={6} xxl={6}>
                <Link
                to={RouteNames.HEROJI_PREGLED}
                className="btn btn=danger siroko"
                >Odustani </Link>
               
            </Col>
            <Col xs={6} sm={6} md={3} lg={6} xl={6} xxl={6}>
            <Button variant="success" type="submit" className="siroko">
                Dodaj Heroji
            </Button>
            
            </Col>
        </Row>
        

        </Form>


        
        
        
        </>



    )
}
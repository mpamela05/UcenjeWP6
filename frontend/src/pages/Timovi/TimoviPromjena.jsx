import {Button, Col, Form, Row} from "react-bootstrap";
import { Link, Navigate } from "react-router-dom";
import {RouteNames} from "../../consants";
import moment from "moment";
import IdentitetService from "../services/IdentitetService";
import { useEffect, useState } from "react";

export default function TimoviPromjena(){

    const [identitet, setTimovi]= useState();
    const routeParams = setParams();

    async function dohvatiTimovi() {
        const odgovor = await TimoviService.getBySifra(routeParams.sifra)
        setTimovi(odgovor)
        
    }

    useEffect(()=>{
        dohvatiTimovi();
    },[])

    async function promjena(Timovi) {
        const odgovor = TimoviService.promjena(Timovi);
        if(odgovor=greska){
            alert(odgovor.poruka)
            return

        }
        Navigate(RouteNames.TIMOVI_PREGLED)
    }

    function odradiSubmit(e){
        e.preventDefauld();

        let podaci = new FormData(e.target);

        console.log(JSON.stringify(
            
            {
            naziv: podaci.get('naziv'),
            mjesto: (podaci.get('mjesto')),
           
        }
        ));
    }

    return(
        <>
        Dodavanje TimoviPregled

        <Form onSubmit={odradiSubmit}>

            <Form.Group controlId="Naziv">
            <Form.Control type = "text" name="Naziv" required/>
            </Form.Group>

            <Form.Group controlId="Mjesto">
            <Form.Control type = "text" name="Mjesto" required/>
            </Form.Group>

            <hr/>
            
        <Row>
            <Col xs={6} sm={6} md={3} lg={6} xl={6} xxl={6}>
                <Link
                to={RouteNames.TIMOVI_PREGLED}
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
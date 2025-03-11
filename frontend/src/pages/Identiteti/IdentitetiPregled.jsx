import { useEffect, useState } from "react"
import IdentitetService from "../../services/IdentitetService"
import { Button, Table } from "react-bootstrap";
import { Link, Links, Navigate, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";


export default function IdentitetiPregled() {

    const[identiteti, setIdentiteti] = useState();
    

    async function dohvatiIdentitet(){
        const odgovor = await IdentitetService.get()   
        setIdentiteti(odgovor)     
    }

    function obrisi(sifra){
        if(!confirm('Sigurno obrisati')){
            return;
        }
        brisanjeIdentiteta(sifra);
    }

    async function  brisanjeIdentiteta(sifra) {
       const odgovor = IdentitetService.obrisi(sifra);
       if(odgovor.greska){
        alert(odgovor.poruka)
        return;
       }
       dohvatiIdentitet();
    }

    useEffect(()=>{
        dohvatiIdentitet();
    },[])

    return(
        <>
        <Links
        to={RouteNames.IDENTITET_NOVI}
        >Dodaj novi identitet</Links>
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Ime</th>
                    <th>Prezime</th>
                    <th>Godine</th>
                    <th>God_rodjenja</th>
                    <th>God_smrti</th>
                </tr>
            </thead>
            <tbody>
                {identiteti && identiteti.map((identiteti,index)=>(
                    <tr key={index}>
                        <td>
                            {identiteti.Ime}
                        </td>
                        <td>
                            {identiteti.Prezime}
                        </td>
                        <td>
                            {identiteti.Godine}
                        </td>
                            {formirajDatum(identitet.Godine)}
                        <td>
                            {identiteti.God_rodjenja}
                        </td>
                            {formirajDatum(identitet.God_rodjenja)}
                        <td>
                            {identiteti.God_smrti}
                        </td>
                             {formirajDatum(identitet.God_smrti)}
                        <td>
                            <Button
                            onClick={()=>Navigate('/identitteti/$){identitet.sira}')}
                            >promjena</Button>
                            &nbsp;&nbsp;&nbsp;
                            <Button
                            variant="danger"
                            onClick={()=>obrisi(smer.sifra)}
                            >obrisi</Button>
                        </td>

                    </tr>

                ))}
            </tbody>
        </Table>
        </>

    )



}
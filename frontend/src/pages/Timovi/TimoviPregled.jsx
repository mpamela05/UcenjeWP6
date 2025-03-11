import { useEffect, useState } from "react"
import IdentitetService from "../../services/IdentitetService"
import { Table } from "react-bootstrap";
import { Link, Links, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";


export default function TimoviPregled() {

    const[identiteti, setimovi] = useState();
    

    async function dohvatiTimovi(){
        const odgovor = await TimoviService.get()   
        setimovi(odgovor)     
    }
    function obrisi(sifra){
        if(!confirm('Sigurno obrisati')){
            return;
        }
        brisanjeTimovi(sifra);

        async function  brisanjeTimovi(sifra) {
            const odgovor = TimoviService.obrisi(sifra);
            if(odgovor.greska){
             alert(odgovor.poruka)
             return;
            }
            dohvatiTimovi();
         }


    useEffect(()=>{
        dohvatiTimovi();
    },[])

    return(
        <>
        <Links
        to={RouteNames.TIMOVI_NOVI}
        >Dodaj novi identitet</Links>
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Naziv</th>
                    <th>Mjesto</th>
                    
                </tr>
            </thead>
            <tbody>
                {Timovi && Timovi.map((imovi,index)=>(
                    <tr key={index}>
                        <td>
                            {Timovi.Naziv}
                        </td>
                        <td>
                            {Timovi.Mjesto}
                        </td>
                       
                    </tr>

                ))}
            </tbody>
        </Table>
        </>

    )



} }
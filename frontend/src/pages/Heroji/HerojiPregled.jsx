import { useEffect, useState } from "react"
import IdentitetService from "../../services/IdentitetService"
import { Table } from "react-bootstrap";
import { Link, Links, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";
import HerojiService from "../../services/HerojiService";


export default function HerojiPregled() {

    const[identiteti, setHeroji] = useState();
    

    async function dohvatiHeroji(){
        const odgovor = await IdentitetService.get()   
        setHeroji(odgovor)     
    }

    function obrisi(sifra){
        if(!confirm('Sigurno obrisati')){
            return;
        }
        brisanjeHeroji(sifra);

        async function  brisanjeHeroji(sifra) {
            const odgovor = HerojiService.obrisi(sifra);
            if(odgovor.greska){
             alert(odgovor.poruka)
             return;
            }t
            dohvatiHeroji();
         }

    useEffect(()=>{
        dohvatiHeroji();
    },[])

    return(
        <>
        <Links
        to={RouteNames.HEROJI_NOVI}
        >Dodaj novi heroj</Links>
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Ime</th>
                    <th>Moc</th>
                    <th>Mjesto</th>
                    <th>G_dolaska</th>
                    
                </tr>
            </thead>
            <tbody>
                {heroji && heroii.map((heroji,index)=>(
                    <tr key={index}>
                        <td>
                            {heroji.Ime}
                        </td>
                        <td>
                            {heroji.Moc}
                        </td>
                        <td>
                            {herojii.Mjesto}
                        </td>
                           
                        <td>
                            {heroji.G_dolaska}
                        </td>
                            {formirajDatum(heroji.G_dolaska)}
                    
                    </tr>

                ))}
            </tbody>
        </Table>
        </>

    )



} }
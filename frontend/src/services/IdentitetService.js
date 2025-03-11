import { HttpService } from "./HttpService";


async function get() {
    return await HttpService.get('/Identitet')
    .then((odgovor)=>{
        console.table(odgovor.data)
    })
    .catch((e)=>{})
}

async function getbySifra(sifra) {
    return await HttpService.get('/Identitet/' + sifra)
    .then((odgovor)=>{
        console.table(odgovor.data)
    })
    .catch((e)=>{})
}

async function dodaj(Identitet) {
    return HttpService.post('/Identitet', Identitet)
    .then(()=>{return{greska:false, poruka: 'Dodano'}})
    .catch(()=>{return{greska:false, poruka: 'Problem kod dodavanja'}})
}
async function Promjena(sifra, Identitet) {
    return HttpService.put('/Identitet/' + sifra, Identitet)
    .then(()=>{return{greska:false, poruka: 'Promjenjeno'}})
    .catch(()=>{return{greska:false, poruka: 'Problem kod promjene'}})
}

async function obrisi(sifra) {
    return HttpService.delete('/Identitet/' + sifra)
    .then(()=>{return{greska:false, poruka: 'Obrisano'}})
    .catch(()=>{return{greska:false, poruka: 'Problem kod brisanja'}})
}
export default{
    get,
    getbySifra,
    dodaj,
    promjena,
    brisanje
}
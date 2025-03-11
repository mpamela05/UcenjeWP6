import { HttpService } from "./HttpService";


async function get() {
    return await HttpService.get('/Timovi')
    .then((odgovor)=>{
        console.table(odgovor.data)
    })
    .catch((e)=>{})
}

async function getbySifra(sifra) {
    return await HttpService.get('/Timovi/' + sifra)
    .then((odgovor)=>{
        console.table(odgovor.data)
    })
    .catch((e)=>{})
}

async function dodaj(Timovi) {
    return HttpService.post('/Timovi', Timovi)
    .then(()=>{return{greska:false, poruka: 'Dodano'}})
    .catch(()=>{return{greska:false, poruka: 'Problem kod dodavanja'}})
}
async function promjena(Timovi) {
    return HttpService.put('/Timovi/' + sifra , Identitet)
    .then(()=>{return{greska:false, poruka: 'promjenjeno'}})
    .catch(()=>{return{greska:false, poruka: 'Problem kod promjene'}})
}
async function obrisi(sifra) {
    return HttpService.delete('/Timovi/' + sifra)
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
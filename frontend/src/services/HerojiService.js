import { HttpService } from "./HttpService";


async function get() {
    return await HttpService.get('/Heroji')
    .then((odgovor)=>{
        console.table(odgovor.data)
    })
    .catch((e)=>{})
}

async function getbySifra(sifra) {
    return await HttpService.get('/Heroji/' + sifra)
    .then((odgovor)=>{
        console.table(odgovor.data)
    })
    .catch((e)=>{})
}

async function dodaj(IHeroji) {
    return HttpService.post('/Heroji', Heroji)
    .then(()=>{return{greska:false, poruka: 'Dodano'}})
    .catch(()=>{return{greska:false, poruka: 'Problem kod dodavanja'}})

}
async function promjena(Heroji) {
    return HttpService.put('/Heroji/'+sifra, Heroji)
    .then(()=>{return{greska:false, poruka: 'Promjenjeno'}})
    .catch(()=>{return{greska:false, poruka: 'Problem kod promjene'}})
}
async function obrisi(sifra) {
    return HttpService.delete('/Heroji/' + sifra)
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
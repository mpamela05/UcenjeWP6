using Ucenje.E17KlasaObjekt.Edunova;

namespace Ucenje.E17KlasaObjekt
{
    internal class Program
    {
        // 5. vrsta metoe (posebna) konstruktor
        // mora imati isti naziv kao i klasa a lista parametara moze biti razlicita 
        public Program() { 
            //Objekt je pojavnost(instanca) klase
            //Osoba je ime klase (primjetiti veliko pocetno slovo)
            //osoba j ime objekta(instanca/pojvosti) = varijabla (malo pocetno slovo)
            Osoba osoba = new Osoba();


           
            osoba.Sifra = 1;

            osoba.Ime = "Pero";
            osoba.Prezime = "Peric";

            Console.WriteLine(osoba.Ime);

            osoba = new Osoba() { Sifra = 2, Ime = "Karlo", Prezime = "Lik" };

            Console.WriteLine("{0},{1}", osoba.Ime, osoba.Prezime);
            Console.WriteLine(osoba.ImePrezime());
            //Console.WriteLine("Izvodjenje staticne metode s klase");

            Osoba.Izvedi();
            Mjesto mjesto = new Mjesto() { Naziv = "Osijek", PostanskiBroj = "31000" };

            //osoba.Mjesto = mjesto;
            //ispisi Osijek
            
            //stari nacin
            
           
            //kraci nacin
            Console.WriteLine(osoba.Mjesto?.Naziv); //? je ovdje indikacija da ne pukne ako je null

            osoba.Mjesto = new Mjesto() { Naziv = "Osijek" };
            Console.WriteLine(osoba.Mjesto.Zupanija?.Zupan ?? "Prazno"); //?? to znaci else

            Smjerovi smjerovi = new Smjerovi() { Naziv = "Web Programiranje" };
            Grupa grupa = new () {Naziv= "WP6", Smjerovi = smjerovi};

            Polaznik[] polazniciNiz = new Polaznik[2];

            polazniciNiz[0] = new Polaznik() { Ime = "Pero" };
            polazniciNiz[1] = new Polaznik() { Ime = "Marija" };

            grupa.Polaznici = polazniciNiz;
            //ispisati podatke o grupi
            Console.WriteLine(grupa.Naziv);
            Console.WriteLine(grupa.Smjerovi.Naziv);
            foreach(Polaznik p in grupa.Polaznici)
            {
                Console.WriteLine("{0} {1}", p.Ime, p.Prezime);
            }
        }
    }
}

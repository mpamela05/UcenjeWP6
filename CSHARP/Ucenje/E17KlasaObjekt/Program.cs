using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Osoba.Izvedi();

            Console.WriteLine("Izvodjenje staticne metode s klase");
        }
    }
}

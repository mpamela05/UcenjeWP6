using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt
{
    // KLasa je opisinik objekta
    internal class Osoba
    {
        //klasa sadrzi svojstva (property)
        public int Sifra { get; set; }   // OOP princip ucahurivanja
        public string? Ime { get; set; } // ? oznacava kako Ime moze biti NULL
        public string? Prezime { get; set; }

        public Mjesto? Mjesto { get; set; }

        public string ImePrezime()
        {
            Console.WriteLine("Izvodjenje metode s objekta");
            return Ime + " " + Prezime;
        }

        public static void Izvedi()
        {
            Console.WriteLine("Izvpdjenje staticne metode s klase");
        }
    }
}

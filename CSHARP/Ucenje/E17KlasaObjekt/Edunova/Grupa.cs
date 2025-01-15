using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.Edunova
{
    public class Grupa
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; } = "";
        public int VelicinaGrupe { get; set; }
        public string? Predavac { get; set; }
        public Smjerovi Smjerovi { get; set; } = new Smjerovi();
        public Polaznik[]? Polaznici { get; set; }
        public void DetaljiGrupe()
        {
            Console.WriteLine(Naziv);
            Console.WriteLine(Smjerovi.Naziv);
            foreach(Polaznik p in Polaznici?? [])
            {
                Console.WriteLine(p.ImePrezime());
            }
        }
    }
}

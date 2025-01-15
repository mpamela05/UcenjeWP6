using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.Edunova
{
    public class Smjerovi
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; } = "";
        public decimal? Cijena { get; set; }
        public DateTime? IzvodiSeOd { get; set; }
        public bool Vaucer { get; set; }
    }
}

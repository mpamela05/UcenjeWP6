using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.NasljedjivanjePolimorfizzam
{
    internal class Osoba
    {

        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";

        public Osoba()
        {
        }

        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.GenericiLambdaEkstenzije
{
    internal class Smjer
    {
        public string? Naziv { get; set; }

        public int CompareTo(Smjer? other)
        {
            return Naziv.CompareTo(other?.Naziv);
        }

        public void OdradiPosao()
        {
            
        }

        
        [Obsolete("Ova metoda je depricated")]
        public string StariNaziv()
        {
            return Naziv + " stari " ?? "";
        }

        public override string ToString()
        {
            return Naziv ?? "";
        }
    }
}

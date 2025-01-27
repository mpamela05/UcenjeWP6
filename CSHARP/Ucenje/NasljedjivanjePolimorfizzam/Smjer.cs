using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.NasljedjivanjePolimorfizzam
{
    internal class Smjer
    {
        public string Naziv { get; set; } = "";

        public override string ToString()
        {
            return Naziv;
        }

        // ovo nije baš pametno, naziv ne određuje jednoznačno smjer
        public override bool Equals(object? obj)
        {
            return ((Smjer)obj).Naziv.Equals(Naziv);
        }

    }
}

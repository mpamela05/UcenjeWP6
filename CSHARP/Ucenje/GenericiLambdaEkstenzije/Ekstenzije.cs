using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.NasljedjivanjePolimorfizzam;

namespace Ucenje.GenericiLambdaEkstenzije
{
    internal class Ekstenzije
    {

        public static void Ispisi(this Entitet e)
        {
            Console.WriteLine(e.Sifra);
        }

    }
}

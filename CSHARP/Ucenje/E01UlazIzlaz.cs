using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E01UlazIzlaz
    {

        public static void Izvedi() 
        {

            Console.WriteLine("Unesi svoje ime: ");

            string Ime = Console.ReadLine();

            Console.WriteLine("Unijeli ste" + Ime);

            Console.WriteLine("Unijeli ste {0}. Bravo!", Ime)
        }


    }
}

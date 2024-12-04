using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E02Z1
    {
        public static void Izvedi() {

            string ime;
            int godine;

            Console.WriteLine("Unesite ime: ");
            ime = Console.ReadLine();
            Console.WriteLine("Unesite godine: ");
            godine = int.Parse(Console.ReadLine());
            Console.WriteLine("osoba {0} ima {1} godine", ime, godine);

            

        }
      


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z2
    {
        public static void Izvedi()
        {
            //Zad1();
            Zad2();
        }

        private static void Zad1()
        {
            Console.WriteLine("dobro dosli u prvi zadatak");
            string ime;
            while (true)
            {

                ime = E12Metode.UcitajString("unesi ime osobe (Ne za kraj): ");
                if (ime.ToUpper() == "NE")
                {
                    break;
                }
            }
            Console.WriteLine(ime.Length);

        }
        private static void Zad2()
        {
            string ime, prezime, jos;
            while (true)
            {
                 ime = E12Metode.UcitajString("unesi ime: ");
                 prezime = E12Metode.UcitajString("unesi prezime: ");
                Console.WriteLine("{0} {1}", prezime, ime);
                if (E12Metode.UcitajString("DA za jos").ToUpper() != "DA")
                {
                    break;
                }
            }

        }
        //unosi ime i prezime osobe, ipisuje prezime i ime
        
    }
}

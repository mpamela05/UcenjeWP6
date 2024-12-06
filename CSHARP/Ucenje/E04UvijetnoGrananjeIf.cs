using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04UvijetnoGrananjeIf
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E04");

            int i = 0;
            bool uvjet = i == 0;
            Console.WriteLine(uvjet);

            if (uvjet)
            {
                Console.WriteLine("Vrijednost varijable i je 0");

            }
            if (1 == 0)
            {
                Console.WriteLine("Cesca sintaksa za provjeru da je i 0");


            }

            i = 17;
            if (i >= 18)
            {
                Console.WriteLine("Punoljetna osoba");
            }
            else
            {
                Console.WriteLine("Maloljetna osoba");
            }

            if (i > 5)
                Console.WriteLine("OK");
            else
                Console.WriteLine("Greska");
            Console.WriteLine("Dio greske");

            int j = 2;
            if (i == 5 & j == 2)
            {
                Console.WriteLine("Dvostruki uvjet je zadvoljen");
            }
            if (i == 5 && j == 2)
            {
                Console.WriteLine("Dvostruki uvjet je zadovoljen");

            }
            if (i == 0 | j == 0)
            {

                Console.WriteLine("Prvi uvjet je zadovoljen");
            }
            if (i == 0 || j == 0) {

                Console.WriteLine("Prvi uvjet je zadovoljen");
            }
            if (i > 0)
            {
                if (j > 0)
                {
                    Console.WriteLine("Ugnjezdjivanje");
                }
            }

            i = 2;

            if (i == 0)
            {
                Console.WriteLine("Nula");
            } else if (i == 1)
            {
                Console.WriteLine("Jedan");

            }
            else
            {
                Console.WriteLine("Ostali brjevi");


            }
            string grad = "Osijek";

            if (grad == "Osijek")
            {
                Console.WriteLine("super");

            }
            else {
                Console.WriteLine("nije super");
            
            }
            Console.WriteLine(grad=="Osijek" ? "super" : "nije super");

            Console.WriteLine((grad == "Osijek" ? "" : "nije") + "Super");

            }
        } 

            
    }         


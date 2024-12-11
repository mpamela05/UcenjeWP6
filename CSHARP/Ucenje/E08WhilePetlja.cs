using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08WhilePetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E08");

            int brojDo = 10;

            for (int i = 0; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }

            while (true) 
            {
                Console.WriteLine("Osijek");
                break;
            }

            int broj = 0;

            while(broj < 10)
            {
                Console.WriteLine(++broj);
            }



            //zbrajanje prvih 100 brojeva s while
            int suma = 0;
            for(int j = 1; j<= 100; j++)
            {
                suma += j;
            }
            Console.WriteLine(suma);

            suma = 0;
            broj = 1;
            while (broj <= 100)
            {
                suma += broj++;
            }
            Console.WriteLine(suma);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Test
    {
        public static void Izvedi() 
        {
            Console.WriteLine("Test");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. Osijek", i);
            }


            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("{0}. Unazad", i);
            }


            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("\t{0}", i * j);
                }
                Console.WriteLine();
            }


            // kako maknuti zadnji zarez 
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    if (i < 20)
                    {
                        Console.Write("{0},", i);
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}

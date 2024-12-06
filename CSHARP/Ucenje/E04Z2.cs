using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 0)
            {
                Console.WriteLine("paran");
            }
            else
            {
                Console.WriteLine("neparan");
            }
            Console.WriteLine(broj % 2 == 0 ? "paran" : "neparan");
        }
    }
}

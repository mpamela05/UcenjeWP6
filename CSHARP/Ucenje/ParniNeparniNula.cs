using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class ParniNeparniNula
    {
        public static void Izvedi()
        {
            Console.WriteLine("upisite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 1)
            {
                Console.WriteLine("neparan");
            }
            else
            {
                Console.WriteLine("paran");
            }
        }
    }
}

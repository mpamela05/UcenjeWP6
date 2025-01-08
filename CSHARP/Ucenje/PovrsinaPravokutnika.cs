using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class PovrsinaPravokutnika
    {
        public static void Izvedi()
        {
            int a, b;
            Console.WriteLine("upisi duljinu: ");
            Console.WriteLine("upisi sirinu: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("umnozak je: " + (a * b));
        }
    }
}

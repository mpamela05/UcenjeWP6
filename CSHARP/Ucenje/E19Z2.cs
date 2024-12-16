using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E19Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E19Z2");
            int b = 12654;
            bool prim = true;
            for(int i = 2; i < b; i++)
            {
                if(b % i == 0)
                {
                 prim = false;
                    break;
                }
            }
            Console.WriteLine(prim ? "da" : "ne");
        } //prim brojevi
    }
}

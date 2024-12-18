using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Tablica
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Tablica");
            int[] tablica = {1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(i);
            }
            

        }
    }
}

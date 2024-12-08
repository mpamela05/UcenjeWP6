using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03Z4
    {
        public static void Izvedi()
        {
            char izbor = 'y';
            while (izbor == 'y')
            { 
                Console.WriteLine("E03");
                int[] brojevi = new int[3];
                int temp;
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Unesite {0} broj", (i + 1));
                    brojevi[i] = int.Parse(Console.ReadLine());
                }
                if (brojevi[0] > brojevi[1])
                {
                    temp = brojevi[0];
                    brojevi[0] = brojevi[1];
                    brojevi[1] = temp;
                }
                if (brojevi[1] > brojevi[2])
                {
                    temp = brojevi[1];
                    brojevi[1] = brojevi[2];
                    brojevi[2] = temp;
                }
                if (brojevi[0] > brojevi[1])
                {
                    temp = brojevi[0];
                    brojevi[0] = brojevi[1];
                    brojevi[1] = temp;
                }
                Console.WriteLine("najmanji je {0} srednji je {1} najveci je {2}", brojevi[0], brojevi[1], brojevi[2]);
                Console.WriteLine("Zelite li jos?");
                izbor = char.Parse(Console.ReadLine());

            }
            
        }
    }

}


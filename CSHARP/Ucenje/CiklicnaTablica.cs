using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {
           //int redova = E12Metode.UcitajCijeliBroj("Upisi broj redova: ");
            //int stupaca = E12Metode.UcitajCijeliBroj("Upisi broj stupaca: ");

            int redova = 5;
            int stupaca = 5;

            int[,] tablica = new int[redova, stupaca];
            IspisiTablicu(tablica);
            int brojac = 1;
            //dolje desna prema lijevo
            for(int i = stupaca -1; i >= 0; i--)
            {
                tablica[redova - 1, i] = brojac++; 
            }
            //IspisiTablicu(tablica);

            
            //dolje lijevo prema gore
            for (int i = stupaca -2; i >= 0 ;i--)
            {
                tablica[i,0] = brojac++;
            }

            //gore lijevo prema desno
            for (int i = stupaca - 4; i <= stupaca - 1; i++)
            {
                tablica[i, stupaca - 1] = brojac++;
            }
            //IspisiTablicu(tablica);


            //od gore desno prema dolje
            for (int i = redova - 4; i <= redova - 2; i++)
            {
                tablica[i, stupaca - 1] = brojac++;
            }
            IspisiTablicu(tablica);




        }
        private static void IspisiTablicu(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i,j] + " ");
                }
                Console.WriteLine();


            }
            Console.WriteLine("---------------------");
        }
    }
}

﻿namespace Ucenje
{
    internal class E19ForEachPetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E19");

            Console.Write("Unesi ime svog grada: ");
            string grad = Console.ReadLine();
            Console.WriteLine(grad);
            char[] znakoviGrad = new char[6];
            znakoviGrad[0] = 'o';
            znakoviGrad[1] = 's';
            znakoviGrad[2] = 'i';
            znakoviGrad[3] = 'j';
            znakoviGrad[4] = 'e';
            znakoviGrad[5] = 'k';

            for (int i = 0; i < 6; i++)
            {
                Console.Write(znakoviGrad[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < grad.Length; i++)
            {
                Console.Write(grad[i]);
            }
            Console.WriteLine();

            foreach(char znak in  znakoviGrad)
            {
                Console.Write(znak);
            }
            Console.WriteLine();
            foreach(char c in grad) 
            {
                Console.Write(c);
            }
            Console.WriteLine();

            for(int i = grad.Length - 1; i >= 0; i--)
            {
                Console.Write(grad[i]);
            }
        }
    }
}


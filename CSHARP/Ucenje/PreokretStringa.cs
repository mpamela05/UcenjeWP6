using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class PreokretStringa
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite rijec");
            string rijec = Console.ReadLine();
            string obrnuto = "";
            for (int i = rijec.Length -1; i >= 0; i--)
            {
                obrnuto += rijec[i];
            }
            Console.WriteLine(rijec = obrnuto);

        }

    }
}

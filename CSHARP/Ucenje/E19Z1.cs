


namespace Ucenje
{
    internal class E19Z1
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E19Z1");
            Console.WriteLine("Unesite rijec: ");
            string rijec = Console.ReadLine();
            string obrnuto = "";
            for (int i = rijec.Length - 1; i >= 0; i--)
            {
                obrnuto += rijec[i]; 

            }
            Console.WriteLine(rijec == obrnuto ? "palindrom" : "nije palindrom");
        }
    }
}

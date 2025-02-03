namespace Ucenje
{
    internal class E13Rekurzija
    {
        public static void Izvedi() 
        {
            //Izvedi();
            Console.WriteLine(Zbroji(100));
        }

        private static int Zbroji(int broj)
        {
            if (broj == 1)
            {
                return 1;
            }
            return broj + Zbroji(broj - 1);
        }
    }
}

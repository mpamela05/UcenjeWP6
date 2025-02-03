namespace Ucenje
{
    internal class ProsjekOcjena
    {
        public static void Izvedi()
        {
            //Console.WriteLine("prosjek ocjena");
            Console.WriteLine("unesi broj ocjena: ");
            int brojOcjena = int.Parse(Console.ReadLine());
            double sumaOcjena = 0;

            for (int i = 1; i <= brojOcjena; i++)
            {
                Console.WriteLine("Unesite ocjenu {i}: ");
                double ocjena = double.Parse(Console.ReadLine());
                double prosjek = sumaOcjena / brojOcjena;
            }
            Console.WriteLine("prosjek ocjena: ");

        }
    }
}

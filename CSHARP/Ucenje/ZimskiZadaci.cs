namespace Ucenje
{
    internal class ZimskiZadaci
    {
        public static void Izvedi()
        {
            //Zad1();
            //Zad2();
            Zad3();
            int a, b;
            //Console.WriteLine("upisi duljinu: ");
            //Console.WriteLine("upisi sirinu: ");
           // a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("umnozak je: " + (a * b));
        }

        //program ispisuje parne i neparne brojeve i nulu
        private static void Zad1()
        {
            
        }
        //zbroj elementa niza(racuna brojeve do 100) nije dobr odradjen zadatak
        private static void Zad2()
        {
            int broj = 0;
            Console.WriteLine("upisi broj: ");
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);

            suma = 0;
            broj = 1;
            while (broj <= 100)
            {
                suma += broj++;

            }
            Console.WriteLine(suma);
        }

        //prosjek ocjena
        private static void Zad3()
        {
           
               

        }
    }
}

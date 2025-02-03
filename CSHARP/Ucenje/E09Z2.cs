namespace Ucenje
{
    internal class E09Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E09Z2");

            int suma = 0, broj;
            while (true)
            {
                Console.Write("Unesi broj: ");
                broj = int.Parse(Console.ReadLine());
                if (broj == -1)
                {
                    break;
                }
                suma = suma + broj;
                
                
            }
            Console.WriteLine(suma);
        }
    }
}

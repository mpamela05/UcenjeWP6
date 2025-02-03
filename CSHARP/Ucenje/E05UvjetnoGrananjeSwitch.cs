namespace Ucenje
{
    internal class E05UvjetnoGrananjeSwitch
    {

        public static void Izvedi() {

            //Console.WriteLine("E05");

            int i = 150;

            switch (i)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Odlican");
                    break;
                case 150:
                    Console.WriteLine("Nemoguce");
                    break;
                default:
                    Console.WriteLine("Ostalo");
                    break;
            }

           
        }

    }
}

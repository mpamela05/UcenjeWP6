namespace Ucenje
{
    internal class E02VarijableTipoviPodataka
    {


        public static void Izvedi() 
        {

            // Console.WriteLine("Hello E02");

            int i;

            Console.WriteLine("Upisi broj: ");

            i=int.Parse(Console.ReadLine());

            Console.WriteLine("Upisali ste {0}, i evo ga jos jednom {1}", i, i);



            bool LogickaVrijednost;

            Console.Write("Unesi True ili False: ");

            LogickaVrijednost = bool.Parse(Console.ReadLine());

            Console.WriteLine("Unijeli ste {0}", LogickaVrijednost);


            Console.Write("Unesi broj (, za decimalni dio): ");

            Console.WriteLine(float.Parse(Console.ReadLine()));

            float broj = 3.14F;

            Console.WriteLine("Unesi ime: ");

            string ime = Console.ReadLine();
            
            Console.WriteLine("Unio sam \n{0}\n{1}\n{2}\n{3}",
                i,LogickaVrijednost,broj,ime);



        }

            

    }
}

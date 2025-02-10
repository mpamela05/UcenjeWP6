namespace Ucenje.NasljedjivanjePolimorfizzam
{
    internal class ObradaUlazniRacun : Obrada
    {
        public override void Procesuiraj()
        {
            Console.WriteLine("Obrađujem ulazni račun");
            Console.WriteLine("Plati ga");
        }
    }
}

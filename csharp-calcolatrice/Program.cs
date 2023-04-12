namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"La somma è {CalcoliHelper.SommaNumeri(2, 3)}");
            Console.WriteLine($"La somma è {CalcoliHelper.SommaNumeri(4.5, 7.6)}" );
            Console.WriteLine($"La differenza è {CalcoliHelper.DifferenzaNumeri(4, 3)}");
            Console.WriteLine( $"La differenza è {CalcoliHelper.DifferenzaNumeri(12.7, 2.6)}");
            Console.WriteLine($"La moltiplicazione è {CalcoliHelper.MoltiplicazioneNumeri(4, 5)}");
            Console.WriteLine($"La moltiplicazione è {CalcoliHelper.MoltiplicazioneNumeri(12.7, 4.6)}");
            Console.WriteLine($"Il valore assoluto è {CalcoliHelper.ValAssoluto(-12)}");
            Console.WriteLine($"Il valore assoluto è {CalcoliHelper.ValAssoluto(-42.5)}");
            Console.WriteLine($"Il numero più piccolo è {CalcoliHelper.MinNum(23,28)}");
            Console.WriteLine($"Il numero più grande è {CalcoliHelper.MaxNum(12, 17)}");
            Console.WriteLine($"L`elevamento a potenza è {CalcoliHelper.ElevamentoPotenza(4, 8)}");
        }
    }
}
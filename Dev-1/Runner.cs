using System;

namespace Dev_1
{
    class Runner
    {
        // Program that outputs sequence 0 to 100, multiples of 3 output as Tutti,
        // multiples of 5 output as Frutti, multiples of 3 and 5 output as Tutti-Frutti.
        static void Main(string[] args)
        {
            const int AmountOfNumb = 100;
            const int MultThree = 3;
            const int MultFive = 5;
            OutputOfNumb OutSeq = new OutputOfNumb();
            OutSeq.Output(AmountOfNumb, MultThree, MultFive);
            Console.ReadKey();
        }
    }
}

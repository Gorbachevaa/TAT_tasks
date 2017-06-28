using System;

namespace Dev_1
{
    class Runner
    {
        // Program that outputs sequence 0 to 100, multiples of 3 output as 3*N.
        static void Main(string[] args)
        {
            int AmountOfNumb = 10;
            int Mult = 3;
            OutputOfNumb OutSeq = new OutputOfNumb();
            OutSeq.Output(AmountOfNumb, Mult);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

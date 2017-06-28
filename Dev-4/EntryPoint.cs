using System;

namespace DEV_4
{
    // A program that determines that the user-entered sequence of integers is nondecreasing. 
    class EntryPoint
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Sequence nondecreaseSeq = new Sequence();
                    int[] seq;
                    seq = nondecreaseSeq.numbTranslater();
                    Console.WriteLine("The entered sequence is a nondecreasing sequence? ");
                    Console.WriteLine(nondecreaseSeq.isNondecreaseSequence(seq));
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! You entered invalid format of number or unnessesary space.");
                }
                finally
                {
                    Console.WriteLine("Press 'esc' to exit. Otherwise press any key to continue.");
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

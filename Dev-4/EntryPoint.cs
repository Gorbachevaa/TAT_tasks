using System;

namespace DEV_4
{
    // A program that determines that the user-entered sequence of integers is nondecreasing. 
    // User could pass sequense as command-line argument. 
    // If user didn't pass argument - the sequense is entered from the console.
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    do
                    {
                        Sequence nondecreaseSeq = new Sequence();
                        int[] seq;
                        seq = nondecreaseSeq.NumbTranslater();
                        Console.WriteLine("The entered sequence is a nondecreasing sequence? ");
                        Console.WriteLine(nondecreaseSeq.IsNondecreaseSequence(seq));
                        Console.WriteLine("Press 'esc' to exit. Otherwise press any key to continue.");
                    }
                    while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                }
                else
                {
                    CommandLine cmd = new CommandLine();
                    cmd.Args = args;
                    Console.WriteLine("The entered sequence is a nondecreasing sequence? ");
                    Console.WriteLine(cmd.IsNondecraseSequence());
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error! You entered invalid format of number or unnessesary space.");
                Console.ReadKey();
            }
        }
    }
}

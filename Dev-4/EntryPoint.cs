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
            const string QUESTION = "The entered sequence is a nondecreasing sequence? ";
            const string INPUTPROMPT = "Enter each number from sequence through enter. Want to stop - press 'S'";
            const string EXITPROPMT = "Press 'esc' to exit. Otherwise press any key to continue.";
            const string FINISHPROMPT = "Press any key to finish.";
            const string ERRMESSAGE = "Error! You entered invalid format of number or unnessesary space.";
            try
            {
                if (args.Length == 0)
                {
                    do
                    {
                        Sequence nondecSeq = new Sequence();
                        Console.WriteLine(INPUTPROMPT);
                        Console.WriteLine(QUESTION);
                        nondecSeq.IsNondecrease();
                        Console.WriteLine(EXITPROPMT);
                    }
                    while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                }
                else
                {
                    CommandLine cmd = new CommandLine();
                    cmd.Args = args;
                    Console.WriteLine(QUESTION);
                    Console.WriteLine(cmd.IsNondecraseSequence());
                    Console.WriteLine(FINISHPROMPT);
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine(ERRMESSAGE);
                Console.ReadKey();
            }
        }
    }
}

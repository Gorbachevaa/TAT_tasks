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
            const string EXITPROPMT = "Press 'esc' to exit. Otherwise press any key to continue.";
            const string ERRMESSAGE = "Error! You entered invalid format of number or unnessesary space.";
            const string SOLUTIONFORERROR = "Please, try again.";
            do
            {
                try
                {
                    Sequence seq = new Sequence();
                    seq.EnterViaCmdOrConsole(args);
                    Console.WriteLine(QUESTION);
                    Console.WriteLine(seq.IsNondecrease());
                }
                catch (Exception)
                {
                    Console.WriteLine(ERRMESSAGE);
                    Console.WriteLine(SOLUTIONFORERROR);
                    Console.ReadKey();
                }
                Console.WriteLine(EXITPROPMT);                    
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}

using System;

namespace DEV_4
{
    // A program that determines that the user-entered sequence of integers is nondecreasing. 
    class EntryPoint
    {
        static void Main(string[] args)
        {
            const string TASKPROMPT = "The entered sequence is a nondecreasing sequence?";
            const string ERRORMSG = "Error! You entered invalid format of number or unnessesary space.";
            const string EXITPROMPT = "Press 'esc' to exit. Otherwise press any key to continue.";
            do
            {
                try
                {
                    Sequence nondecreaseSeq = new Sequence();
                    int[] seq = nondecreaseSeq.Input();
                    Console.WriteLine(TASKPROMPT);
                    Console.WriteLine(nondecreaseSeq.IsNondecrease(seq));
                }
                catch (Exception)
                {
                    Console.WriteLine(ERRORMSG);
                }
                finally
                {
                    Console.WriteLine(EXITPROMPT);
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

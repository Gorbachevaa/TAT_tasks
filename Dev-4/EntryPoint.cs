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
<<<<<<< HEAD
            const string QUESTION = "The entered sequence is a nondecreasing sequence? ";
            const string EXITPROPMT = "Press 'esc' to exit. Otherwise press any key to continue.";
            const string ERRMESSAGE = "Error! You entered invalid format of number or unnessesary space.";
            const string SOLUTIONFORERROR = "Please, try again.";
=======
            const string TASKPROMPT = "The entered sequence is a nondecreasing sequence?";
            const string ERRORMSG = "Error! You entered invalid format of number or unnessesary space.";
            const string EXITPROMPT = "Press 'esc' to exit. Or try again( Press any symbol.).";
>>>>>>> 27da1d6aa8efd70b1e120e3e016993135d11e296
            do
            {
                try
                {
<<<<<<< HEAD
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
=======
                    Sequence sequence = new Sequence();
                    sequence.TranslateEnteredNumbers();
                    Console.WriteLine(TASKPROMPT);
                    Console.WriteLine(sequence.IsNonDecrease());
                }
                catch (Exception)
                {
                    Console.WriteLine(ERRORMSG);
                }
                finally
                {
                    Console.WriteLine(EXITPROMPT);
>>>>>>> 27da1d6aa8efd70b1e120e3e016993135d11e296
                }
                Console.WriteLine(EXITPROPMT);                    
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}

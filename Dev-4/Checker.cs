using System;

namespace DEV_4
{
    // Class that determines how sequence is entered and checks if sequence is nondecreasing.
    class Checker
    {
        const string INPUTPROMPT = "Enter a sequence of number with a one space. ";
        const string CONDITIONTOFINISH = "To finish input of number press Enter: ";
        const string CMDPROMPT = "String from command line: ";
        const string QUESTION = "The entered sequence is a nondecreasing sequence? ";

        // Method that determines how sequence is entered and checks if sequence is nondecreasing.
        public void CmdAnalyze(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Write(INPUTPROMPT);
                Console.WriteLine(CONDITIONTOFINISH);
                Sequence nondecSeq = new Sequence();
                nondecSeq.Inputer();
                Console.WriteLine(QUESTION);
                Console.WriteLine(nondecSeq.IsNondecrease());
            }
            else
            {
                CommandLine cmdSeq = new CommandLine();
                cmdSeq.Args = args;
                Console.Write(CMDPROMPT);
                cmdSeq.CmdReader();
                Console.WriteLine(QUESTION);
                Console.WriteLine(cmdSeq.IsNondecrease());
            }
        }
    }
}

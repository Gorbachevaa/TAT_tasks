using System;

namespace DEV_4
{
    // Class that determines how sequence is entered.
    class Checker
    {
        const string INPUTPROMPT = "Enter a sequence of number with a one space. ";
        const string CONDITIONTOFINISH = "To finish input of number press Enter: ";
        const string CMDPROMPT = "String from command line: ";
        public string[] Seq { get; set; }
        // Method that determines how sequence is entered and checks if sequence is nondecreasing.
        public void CmdAnalyze(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Write(INPUTPROMPT);
                Console.WriteLine(CONDITIONTOFINISH);
                Sequence sequence = new Sequence();
                sequence.Inputer();
                Seq = sequence.Tokens;
            }
            else
            {
                CommandLine cmdLine = new CommandLine();
                cmdLine.Args = args;
                Console.Write(CMDPROMPT);
                cmdLine.Reader();
                Seq = cmdLine.Args;
            }
        }
    }
}

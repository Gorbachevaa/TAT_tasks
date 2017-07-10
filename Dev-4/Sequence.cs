using System;

namespace DEV_5
{
    class Sequence
    {
        const string INPUTPROMPT = "Enter a sequence of number with a one space. ";
        const string CONDITIONTOFINISH = "To finish input of number press Enter: ";
        const string CMDPROMPT = "String from command line: ";
        public int[] Number { get; set; }
        // Method that determines how sequence is entered and returns integer value of string.
        public void EnterViaCmdOrConsole(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Write(INPUTPROMPT);
                Console.WriteLine(CONDITIONTOFINISH);
                string[] tokens = Console.ReadLine().Split();
                Number = StrTranslater(tokens);
            }
            else
            {
                Console.WriteLine(CMDPROMPT);
                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write(args[i] + " ");
                }
                Console.WriteLine();
                Number = StrTranslater(args);
            }
        }
        // Method that translaste entered numbers into an array of integer values.
        public int[] StrTranslater(string[] tokens)
        {
            int[] number = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                number[i] = Convert.ToInt32(tokens[i], 10);
            }
            return number;
        }

        // Method that checks if sequence is nondecreasing.
        public bool IsNonDecrease()
        {
            bool isNonDecrease = true;
            if (Number.Length == 1)
            {
                isNonDecrease = false;
            }
            for (int i = 1; i < Number.Length; i++ )
            {
                if (Number[i] < Number[i - 1])
                {
                    isNonDecrease = false;
                    break;
                }
            }
            return isNonDecrease;
        }
    }
}

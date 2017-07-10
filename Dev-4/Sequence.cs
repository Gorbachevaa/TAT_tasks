using System;

namespace DEV_4
{
    class Sequence
    {
        const string INPUTPROMPT = "Enter a sequence of number with a one space. ";
        const string CONDITIONTOFINISH = "To finish input of number press Enter: ";
<<<<<<< HEAD
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
                int[] numbSequence = StrTranslater(tokens);
                Number = numbSequence;
            }
            else
            {
                Console.WriteLine(CMDPROMPT);
                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write(args[i] + " ");
                }
                Console.WriteLine();
                int[] numbSequence = StrTranslater(args);
                Number = numbSequence;
            }
        }

        // Method that translastes entered numbers into an array of integer values.
        public int[] StrTranslater(string[] tokens)
        {
            int[] number = new int[tokens.Length];
=======
        public int[] Number { get; set; }
        
        // Method that translaste entered numbers into an array of integer values.
        public void TranslateEnteredNumbers()
        {
            Console.Write(INPUTPROMPT);
            Console.WriteLine(CONDITIONTOFINISH);
            string[] tokens = Console.ReadLine().Split();
            Number = new int[tokens.Length];
>>>>>>> 27da1d6aa8efd70b1e120e3e016993135d11e296
            for (int i = 0; i < tokens.Length; i++)
            {
                Number[i] = Convert.ToInt32(tokens[i], 10);
            }
        }

        // Method that checks if sequence is nondecreasing.
<<<<<<< HEAD
        public bool IsNondecrease()
        {
            int[] number = Number;
            bool isNondecrease = true;
            if (number.Length == 1)
            {
                isNondecrease = false;
            }
            for (int i = 1; i < number.Length; i++ )
=======
        public bool IsNonDecrease()
        {
            bool isNonDecrease = true;
            if (Number.Length == 1)
>>>>>>> 27da1d6aa8efd70b1e120e3e016993135d11e296
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
<<<<<<< HEAD
            }
            return isNondecrease;
=======
            } 
            return isNonDecrease;
>>>>>>> 27da1d6aa8efd70b1e120e3e016993135d11e296
        }
    }
}

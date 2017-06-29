using System;

namespace DEV_4
{
    // Class that works with values from command line. 
    class CommandLine
    {
        public string[] Args { get; set; }

        public int[] IntArgs { get; set; }
        public int AmountOfSymbols { get; set; }

        // Method that count amount of arguments. 
        public void ArgsCounter()
        {
            string[] str = Args;
            int n = str.Length;
            int amountOfSymbols = 0;
            for (int i = 0; i < n; i++)
            {
                int k = str[i].Length;
                for (int j = 0; j < k; j++)
                {
                    amountOfSymbols++;
                }
            }
            AmountOfSymbols = amountOfSymbols;
        }

        // Method that translate string array to int array. 
        public void Input()
        {
            ArgsCounter();
            int n = AmountOfSymbols;
            int[] number = new int[n];
            IntArgs = number;
            string[] tokens = Args;
            for (int i = 0; i < n; i++)
            {
                number[i] = Convert.ToInt32(tokens[i], 10);
                IntArgs[i] = number[i];
            }
        }

        // Method that checks if sequence is nondecreasing.
        public bool IsNondecraseSequence()
        {
            Input();
            bool isNondecrease = true;
            int i = 1;
            int n = AmountOfSymbols;
            int[] tokens = IntArgs;
            while (i < n)
            {
                if (tokens[i] < tokens[i - 1])
                {
                    isNondecrease = false;
                    break;
                }
                i++;
            }
            return isNondecrease;
        }
    }
}

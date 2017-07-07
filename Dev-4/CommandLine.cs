using System;

namespace DEV_4
{
    // Class that reads values from command line.
    public class CommandLine
    {
        public string[] Args { get; set; }
        public int[] IntArgs { get; set; }

        // Method that reads from coomand line and writes to console.
        public void Reader()
        {
            string[] args = Args;
            foreach (string arg in args)
            {
                Console.Write(arg + " ");
            }
            Console.WriteLine();
        }
        // Method that translastes entered numbers into an array of integer values.
        public void StrTransater()
        {
            string[] args = Args;
            IntArgs = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                IntArgs[i] = Convert.ToInt32(args[i], 10);
            }
        }
        // Method that checks if sequence is nondecreasing.
        public bool IsNondecrease()
        {
            StrTransater();
            int[] number = IntArgs;
            bool isNondecrease = true;
            if (number.Length == 1)
            {
                isNondecrease = false;
            }
            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] < number[i - 1])
                {
                    isNondecrease = false;
                    break;
                }
            }
            return isNondecrease;
        }
    }
}

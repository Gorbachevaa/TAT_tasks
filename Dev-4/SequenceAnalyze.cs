using System;

namespace DEV_4
{
    // Class that analyzes sequence and checks if seuence is nondecreasing. 
    class SequenceAnalyze
    {
        const string QUESTION = "The entered sequence is a nondecreasing sequence? ";
        public string[] Tokens { get; set; }
        public int[] IntTokens { get; set; }
        // Method that translastes entered numbers into an array of integer values.
        public void StrTransater()
        {
            string[] tokens = Tokens;
            IntTokens = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                IntTokens[i] = Convert.ToInt32(tokens[i], 10);
            }
        }
        // Method that checks if sequence is nondecreasing.
        public bool IsNondecrease()
        {
            StrTransater();
            int[] number = IntTokens;
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
        // Method that writes if sequence is nondecreasing or not. 
        public void WriteAnswer()
        {
            Console.WriteLine(QUESTION);
            Console.WriteLine(IsNondecrease());
        }
    }
}

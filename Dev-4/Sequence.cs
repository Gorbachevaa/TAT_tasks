using System;

namespace DEV_4
{
    public class Sequence
    {
        public string[] Tokens { get; set; }
        public int[] IntTokens { get; set; }

        // Method that assigns the entered values to class field tokens.
        public void Inputer()
        {
            Tokens = Console.ReadLine().Split();
            Console.WriteLine();
        }
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
            for (int i = 1; i < number.Length; i++ )
            {
                if (number[i] < number[i - 1])
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

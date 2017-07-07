using System;

namespace DEV_4
{
    class Sequence
    {
        public int[] Number { get; set; }
        const string INPUTPROMPT = "Enter a sequence of number with a one space. ";
        const string CONDITIONTOFINISH = "To finish input of number press Enter: ";
        // Method that translaste entered numbers into an array of integer values.
        public void TranslateEnteredNumbers()
        {
            Console.Write(INPUTPROMPT);
            Console.WriteLine(CONDITIONTOFINISH);
            string[] tokens = Console.ReadLine().Split();
            int[] number = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                number[i] = Convert.ToInt32(tokens[i], 10);
            }
            Number = number;
        }

        // Method that checks if sequence is nondecreasing.
        public bool IsNondecrease()
        {
            int[] number = Number;
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
            } 
            return isNondecrease;
        }
    }
}

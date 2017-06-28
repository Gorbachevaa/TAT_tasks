using System;

namespace DEV_4
{
    class Sequence
    {
        // Method that translaste entered numbers into an array of integer values.
        public int[] NumbTranslater()
        {
            Console.Write("Enter a sequence of number with a space.");
            Console.WriteLine("Enter one space between numbers. ");
            Console.WriteLine("To finish input of number press Enter: ");
            string[] tokens = Console.ReadLine().Split();
            int[] number = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                number[i] = Convert.ToInt32(tokens[i], 10);
            }
            return number;
        }

        // Method that checks if sequence is nondecreasing.
        public bool IsNondecreaseSequence(int[] number)
        {
            bool isNondecrease = true;
            int i = 1;
            int n = number.Length;
            while (i < n)
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

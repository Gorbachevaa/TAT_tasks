﻿using System;

namespace DEV_4
{
    class Sequence
    {
        const string INPUTPROMPT = "Enter a sequence of number with a one space. ";
        const string CONDITIONTOFINISH = "To finish input of number press Enter: ";
        // Method that translaste entered numbers into an array of integer values.
        public int[] Input()
        {
            Console.Write(INPUTPROMPT);
            Console.WriteLine(CONDITIONTOFINISH);
            string[] tokens = Console.ReadLine().Split();
            int[] number = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                number[i] = Convert.ToInt32(tokens[i], 10);
            }
            return number;
        }

        // Method that checks if sequence is nondecreasing.
        public bool IsNondecrease(int[] number)
        {
            bool isNondecrease = true;
            int i = 1;
            while (i < number.Length)
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
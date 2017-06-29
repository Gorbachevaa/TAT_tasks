using System;

namespace DEV_4
{
    class Sequence
    {
        // Method that translaste entered numbers into an array of integer values.
        public int Input()
        {
            string token = Console.ReadLine();
            int number = 0;
            number = Convert.ToInt32(token, 10);
            return number;
        }

        // Method that checks if sequence is nondecreasing.
        public bool IsNondecrease()
        {
            bool isNondecrease = true;
            int prevNumb = Input(), nextNumb = 0;
            do
            {
                nextNumb = Input();
                if (prevNumb > nextNumb)
                {
                    isNondecrease = false;
                }
                prevNumb = nextNumb;
            }
            while ((Console.ReadKey(true).Key != ConsoleKey.S) && (isNondecrease));
           // Console.WriteLine(RESULT + isNondecrease);
            return isNondecrease;

        }
    }
}

using System;

namespace DEV_4
{
    class Sequence
    {
        const string RESULT = "The entered sequence is a nondecreasing sequence? ";
        // Method that translaste entered numbers into an array of integer values.
        public int NumbTranslater()
        {
            string token = Console.ReadLine();
            int number = 0;
            number = Convert.ToInt32(token, 10);
            return number;
        }

        // Method that checks if sequence is nondecreasing.
        public void IsNondecrease()
        {
            bool isNondecrease = true;
            int prevNumb = NumbTranslater(), nextNumb = 0;
            do
            {
                nextNumb = NumbTranslater();
                if (prevNumb > nextNumb)
                {
                    isNondecrease = false;
                }
                prevNumb = nextNumb;
            }
            while ((Console.ReadKey(true).Key != ConsoleKey.S) && (isNondecrease));
            Console.WriteLine(RESULT + isNondecrease);

        }
    }
}

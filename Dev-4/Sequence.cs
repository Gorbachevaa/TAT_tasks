using System;

namespace DEV_4
{
    class Sequence
    {
        const string INPUTPROMPT = "Enter a sequence of number with a one space. ";
        const string CONDITIONTOFINISH = "To finish input of number press Enter: ";
        public int[] Number { get; set; }
        
        // Method that translaste entered numbers into an array of integer values.
        public void TranslateEnteredNumbers()
        {
            Console.Write(INPUTPROMPT);
            Console.WriteLine(CONDITIONTOFINISH);
            string[] tokens = Console.ReadLine().Split();
            Number = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                Number[i] = Convert.ToInt32(tokens[i], 10);
            }
        }

        // Method that checks if sequence is nondecreasing.
        public bool IsNonDecrease()
        {
            bool isNonDecrease = true;
            if (Number.Length == 1)
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
            } 
            return isNonDecrease;
        }
    }
}

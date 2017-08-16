using System;

namespace DEV_4
{
    // Class that reads sequence from console.
    public class Sequence
    {
        public string[] Tokens { get; set; }

        // Method that assigns the entered values to class field tokens.
        public void Inputer()
        {
            Tokens = Console.ReadLine().Split();
        }
    }
}

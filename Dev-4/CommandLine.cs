using System;

namespace DEV_4
{
    // Class that reads values from command line.
    public class CommandLine
    {
        public string[] Args { get; set; }

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
    }
}

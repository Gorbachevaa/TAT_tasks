using System;

namespace Dev_1
{
    // Class that realize output of all numbers by the task.
    class OutputOfNumb
    {
        // Method that outputs the requried sequence.
        public void Output(int n, int mult)
        {
            MultipleNumb multipleNumb = new MultipleNumb();
            
            for (var i = 0; i < n + 1; i++)
            {
                if (!multipleNumb.isMultiple(i,mult))
                {
                    Console.WriteLine(i);
                }
                else
                    Console.WriteLine(mult + "*" + i / mult);
            }
        }
    }
}

using System;

namespace Dev_1
{
    // Class that realize output of all numbers by the task.
    class OutputOfNumb
    {
        // Method that outputs the required sequence.
        public void Output(int n, int mult1, int mult2)
        {
            MultipleNumb multipleNumb = new MultipleNumb();

            for (var i = 0; i < n + 1; i++)
            {
                if (multipleNumb.isMultiple(i, mult1) && multipleNumb.isMultiple(i, mult2))
                {
                    Console.WriteLine("Tutti-Frutti");
                }
                else
                    if (multipleNumb.isMultiple(i, mult1))
                    {
                        Console.WriteLine("Tutti");
                    }
                    else
                        if (multipleNumb.isMultiple(i, mult2))
                        {
                            Console.WriteLine("Frutti");
                        }
                        else
                            Console.WriteLine(i);
            }
        }
    }
}

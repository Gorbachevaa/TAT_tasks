using System;

namespace Dev_3
{
    class Program
    {
        // Program that checks whether number is a Fibonacci number.
        static void Main(string[] args)
        {
            try
            {
                uint number;
                FibonacciNumber fibNumb = new FibonacciNumber();
                Console.WriteLine(" Enter the number: ");
                // Checks the correctness of the number
                number = Convert.ToUInt32(Console.ReadLine(), 10);
                Console.WriteLine(" The number " + number + " is a Fibbonacci number? ");
                Console.WriteLine(fibNumb.IsFibbonacci(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format of input number. ");
            }
            catch (OverflowException)
            {
                Console.WriteLine(" The number is too large or negative. ");
            }
            finally
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}

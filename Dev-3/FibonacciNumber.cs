using System;

namespace Dev_3
{
    // Class that realizes Fibonacci number.
    class FibonacciNumber
    {
        // Method that checks whether the number is a Fibonacci.
        public bool IsFibbonacci(uint number)
        {
            const int n = 100;
            uint[] F = new uint[n];
            F[0] = 0;
            F[1] = 1;
            int i = 2;
            while (number > F[i-1])
            {
                F[i] = F[i - 1] + F[i - 2];
                i++;
            }
            if (number == F[0])
                return true;
            else
                return number == F[i - 1];
        }

    }
}

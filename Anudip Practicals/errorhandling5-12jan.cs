using System;
namespace ExceptionThrowSample
{
    class MathOps
    {
        // Create an array of numbers  
        int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

        public int FindPrimeNumber(int index)
        {
            if (index < 0 || index >= primes.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return primes[index];
        }

        public double DivideNumber(int num1, int num2)
        {
            // If num2 is 0, throw an exception  
            if (num2 == 0)
                throw new DivideByZeroException();
            if (num1 < num2)
                num1 += 20;
            return num1 / num2;
        }
    }
}



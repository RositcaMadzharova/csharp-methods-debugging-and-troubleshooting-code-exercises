using System;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = CalculateFibonacci(number);
            Console.WriteLine(result); ;

        }

        static int CalculateFibonacci(int number)
        {
            int result = 0;

            if (number == 0 || number == 1)
            {
                result = 1;
                return result;
            }

            int previousNunber = 1;
            int beforePrevious = 1;
            for (int i = 2; i <= number; i++)
            {
                result = previousNunber + beforePrevious;
                beforePrevious = previousNunber;
                previousNunber = result;
            }

            return result;
        }
    }
}

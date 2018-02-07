using System;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));

        }

        static bool IsPrime(ulong number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            bool isPrime = false;

            for (ulong i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

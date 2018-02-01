using System;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int biggest = GetMax(first, Math.Max(second, third));
            Console.WriteLine(biggest);
        }

        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }

            else return second; 
        }
    }
}

using System;

namespace English_Name_оf_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(LastDigit(input));
        }

        static string LastDigit(long input)
        {
            long LastDigit = Math.Abs(input % 10);

            switch (LastDigit)
            {
                case 0:
                    return "zero";  
                case 1:
                    return "one"; 
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "null";
            }
        }
    }
}

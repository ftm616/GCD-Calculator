using System;

namespace GCD_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            int gcd = FindGCD(num1, num2);

            Console.WriteLine($"The greatest common multiple of two numbers {num1} and {num2} is equal to: {gcd}");
            Console.ReadKey();
        }
        static int FindGCD(int a, int b)
        {
            if (b == 0) 
                return a;
            return FindGCD(b, a % b); 
        }
    }
}

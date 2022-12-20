using System;
using System.Diagnostics.CodeAnalysis;

namespace ConvertTo
{

    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;

            Console.WriteLine("Enter number 1:");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter number 2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;

            Console.WriteLine($"The sum is {sum}");




        }


    }
}


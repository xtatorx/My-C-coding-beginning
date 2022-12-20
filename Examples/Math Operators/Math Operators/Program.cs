using System;
namespace Math
{

    class Program
    {

        static void Main(string[] args)
        {
            int num1, num2, add, subt, div, mult, rem;
            num1 = 15;
            num2 = 3;
            add = num1 + num2;
            subt = num1 - num2;
            div = num1 / num2;
            mult = num1 * num2;
            rem = num1 % num2; // modulus operator -- remainder operator  7%2 =3 and remaining 1
            
            Console.WriteLine("number1 is" + num1);
            Console.WriteLine("number is" + num2);
            Console.WriteLine(num1 + "plus" + num2 "is" + add);
            Console.WriteLine(num1 + "minus" + num2 "is" + subt);
            Console.WriteLine(num1 + "divided by" + num2 "is" + div);
            Console.WriteLine(num1 + "multiplied by" + num2 "is" + mult);
            Console.WriteLine(num1 + "divided" + num2 "is" + div + "and remaining" + rem);


        }



    }
}

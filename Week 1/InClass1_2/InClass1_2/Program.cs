/* Brian Thorne
 * 12/15/2022
 * CIS 214 Week 1 In Class 1.2
 * */

using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        double number1, number2, number3, average, min, max, product;
        min = 0;
        max = 0;
        Console.WriteLine("Enter the 1st number");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 2nd number");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 3rd number");
        number3 = Convert.ToInt32(Console.ReadLine());

        average = (number1 + number2 + number3) / 3;

        if (number1 <= number2 && number1 <= number3)
        {
            min = number1;
        }

        else if (number1 >= number2 && number1 >= number3)
        {
            max = number1;
        }

        if (number2 <= number1 && number2 <= number3)
        {
            min = number2;
        }

        else if (number2 >= number1 && number1 >= number3)
        {
            max = number2;
        }
        if (number3 <= number1 && number3 <= number2)
        {
            min = number3;
        }
        else if (number3 >= number1 && number3 >= number2)
        {
            max = number3;
        }
        product = number1 * number2 * number3;

        Console.WriteLine("\n Average of the three numbers is {0}", average);
        Console.WriteLine("\n Smallest number is {0}", min);
        Console.WriteLine("\n the product of the three number is {0}", product);
        Console.WriteLine("\n the max number is {0}", max);

    }



}

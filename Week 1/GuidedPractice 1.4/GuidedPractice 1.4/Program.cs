/*******************************************************************
* Name: Brian Thorne
* Date: 12/13/2022
* Assignment CIS214 Week 1 GP – Operators and Data Types
*
* Main application (program) class.
* In this application we will declare variables of various types, compare
* variables using comparison operators, get numeric values from the user
* via the console, add the numbers received, and print the results of
* each operation performed.
*/
using static System.Net.Mime.MediaTypeNames;

public class OperatorsDataTypes
{
    static void Main(string[] args)
    {
        //Print a header line
        Console.WriteLine("\nBrian Thorne - Week 1 GP Operators & Data Types\n");
        //Declare 3 integer values
        int intVal1 = 0;
        int intVal2 = 5;
        int intVal3 = 5;
        //Demonstrate comparison operators
        //Equality
        if (intVal2 == intVal3)
        {
            Console.WriteLine("{0:D} is equal to {1:D}", intVal2, intVal3);
        }
        //Inequality
        if (intVal1 != intVal3)
        {
            Console.WriteLine("{0:D} is not equal to {1:D}", intVal1, intVal3);
        }
        //Less Than
        if (intVal1 < intVal3)
        {
            Console.WriteLine("{0:D} is less than to {1:D}", intVal1, intVal3);
        }
        //Greater Than
        if (intVal2 > intVal1)
        {
            Console.WriteLine("{0:D} is greater than to {1:D}", intVal2,
            intVal1);
        }
        //Less Than or Equal To
        if (intVal2 <= intVal3)
        {
            Console.WriteLine("{0:D} is less than or equal to {1:D}", intVal2,
            intVal3);
        }
        //Greater Than or Equal To
        if (intVal2 >= intVal3)
        {
            Console.WriteLine("{0:D} is greater than or equal to {1:D}",
            intVal2, intVal3);
        }
        //Get 2 integer values from the user and add them together
        Console.Write("Enter an integer value: ");
        //Get a value from the user - note that we declare "val" as
        // string? rather than string - the ? means that the type can
        // be null; if we don't do that a warning is generated when
        // compiling
        string? val = Console.ReadLine();
        intVal1 = Convert.ToInt32(val);
        Console.Write("Enter a second integer value: ");
        val = Console.ReadLine();
        intVal2 = Convert.ToInt32(val);
        int sum = intVal1 + intVal2;
        Console.WriteLine("The sum of {0:D} and {1:D} is {2:D}.",
        intVal1, intVal2, sum);
        //Get 2 floating-point values from the user and add them together
        Console.Write("Enter a floating point value: ");
        val = Console.ReadLine();
        double fltVal1 = Convert.ToDouble(val);
        Console.Write("Enter a second floating point value: ");
        val = Console.ReadLine();
        double fltVal2 = Convert.ToDouble(val);
        double total = fltVal1 + fltVal2;
        Console.WriteLine("The sum of {0:F3} and {1:F3} is {2:F3}.",
        fltVal1, fltVal2, total);
    }
}

/******************************************************************* 
 * Name: Brian Thorne
 * Date: 12/20/2022
 * Assignment CIS214 Week 2 GP – Decisions & Logical Operators 
 *  
 * Main application (program) class. 
 * In this application we will demonstrate how logical operators function 
 * by printing "truth" tables to show the results of various logical and 
 * conditional operators. We will also explore decision making through 
 * the use of both an if-else statement and a switch statement. 
*/


public class App
{
    static void Main(string[] args)
    {
        // print a header line
        Console.WriteLine("\n Brian Thorne- Week 2 GP Decisions & Logical Operators \n");

        // Display a truth table for conditional AND (&&) operator
        Console.WriteLine("Conditional AND (&&): \n {0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
            "false && false", false && false,
            "false && true", false && true,
            "true && false", true && false,
            "true & true",  true && true);

        //Display a truth table for conditional OR (||) operator 
        Console.WriteLine(
            "Conditional OR (||):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
                "false || false", false || false,
                "false || true", false || true,
                "true || false", true || false,
                "true || true", true || true);

        //Display a truth table for Logical AND (&) operator 
        Console.WriteLine(
            "Logical AND (&):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
                "false & false", false & false,
                "false & true", false & true,
                "true & false", true & false,
                "true & true", true & true);

        //Display a truth table for Logical inclusive OR (|) operator 
        Console.WriteLine(
            "Logical OR (|):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
                "false | false", false | false,
                "false | true", false | true,
                "true | false", true | false,
                "true | true", true | true);

        //Display a truth table for Logical exclusive OR (^) operator 
        Console.WriteLine(
            "Logical exclusive OR (^):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
                "false ^ false", false ^ false,
                "false ^ true", false ^ true,
                "true ^ false", true ^ false,
                "true ^ true", true ^ true);

        //Display a truth table for logical negation (!) operator 
        Console.WriteLine(
            "Logical negation (!):\n{0}: {1}\n{2}: {3}\n",
                "!false", !false,
                "!true", !true);



        //Get 2 integer values from the user and add them togehter 
        Console.Write("\nEnter an integer grade in range 0 - 100: ");
        string? val = Console.ReadLine();
        int grade = Convert.ToInt32(val);

        //Determine the letter grade using and if-else structure 
        Console.WriteLine("Determining grade using if-else:");
        if (grade >= 90)
        {
            Console.WriteLine("The grade entered is an A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("The grade entered is a B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("The grade entered is a C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("The grade entered is a D.");
        }
        else
        {
            Console.WriteLine("The grade entered is an F.");
        }


        // Determine the letter grade using a switch structure
        Console.WriteLine("\nDetermining grade using switch:");

        //Use grade divided by 10 (grade/10) to get just the first 
        //digit of the grade 
        switch (grade / 10)
        {
            case 9:
            case 10:
                Console.WriteLine("The grade entered is an A.");
                break;
            case 8:
                Console.WriteLine("The grade entered is a B.");
                break;
            case 7:
                Console.WriteLine("The grade entered is a C.");
                break;
            case 6:
                Console.WriteLine("The grade entered is a D.");
                break;
            default:
                Console.WriteLine("The grade entered is an F.");
                break;
        }
    }
}


    





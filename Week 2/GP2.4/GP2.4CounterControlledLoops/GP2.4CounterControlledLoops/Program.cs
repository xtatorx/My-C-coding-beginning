/*******************************************************************
* Name: Brian Thorne
* Date: 12/20/2022
* Assignment CIS214 Week 2 GP – Counter Controlled Loops
*
* Main application (program) class.
* In this application we will demonstrate the use of counter-controlled
* loops and increment/decrement operators by showing several examples
* of counted operations.
*/


public class CounterControlledLoops
{

    static void Main(string[] args)
    {
        //Print a header line
        Console.WriteLine("\n Brian Thorne - Week2 Gp Counter Controlled Loops\n");

        //prefix increment and decrement operators
        int c = 5;

        Console.WriteLine("Value of c before prefix increment: {0}", c);
        Console.WriteLine("Value of c with prefix increment (++c): {0} ", ++c);
        Console.WriteLine("Value of c after prefix increment: {0}\n", c);

        c = 5;
        Console.WriteLine("Value of c before prefix decrement: {0}", c);
        Console.WriteLine("Value of c with prefix decrement (--c): {0}", --c);
        Console.WriteLine("Value of c after prefix decrement: {0}\n", c);

        //Suffix increment (postincrement) & decrement operators
        c = 5;
        Console.WriteLine("Value of c before suffix increment: {0}", c);
        Console.WriteLine("Value of c with suffix increment (c++): {0}", c++);
        Console.WriteLine("Value of c after suffix increment: {0}\n", c);

        c = 5;
        Console.WriteLine("Value of c before suffix decrement: {0}", c);
        Console.WriteLine("Value of c with suffix decrement (c--): {0}", c--);
        Console.WriteLine("Value of c after suffix decrement: {0}\n", c);

        //counter controled while loop
        Console.WriteLine("Counter controlled loop demonstration");

        int wcnt1 = 1;

        while (wcnt1 <= 10)
        {
            Console.Write("{0}", wcnt1);
            wcnt1++;
        }

        //same thing, with a for loop
        Console.WriteLine("\n\nfor Loop demonstration");
        for (int cnt = 1; cnt <= 10; cnt++)
        {
            Console.Write("{0} ", cnt);
        }


        //now the countdown...
        Console.WriteLine("\n\nwhile loop countdown");
        int wcnt2 = 10;
        while (wcnt2 >= 0)
        {
            Console.Write("{0} ", wcnt2);
            wcnt2--;
        }

        //same thing, with a for loop
        Console.WriteLine("\n\nfor loop countdown");
        for (int cnt = 10; cnt >= 0; cnt--)
        {
            Console.Write("{0} ", cnt);
        }


    }

}
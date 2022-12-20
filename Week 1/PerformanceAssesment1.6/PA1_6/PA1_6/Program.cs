/* Brian thorne
 * 12/15/2022
 * CIS 214 Week 1 PA1.6 IO & Operators
 */

namespace MyMath
{
    public class Operators
    {

        static void Main(string[] args)
        {
            int val1, val2, sum;
            double val3, val4, total;

            Console.WriteLine("\n Brian Thorne - Week 1 PA IO & Operators");

            Console.WriteLine("Enter integer value 1:");
            val1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter integer value 2:");
            val2 = Convert.ToInt32(Console.ReadLine());

            sum = val1 + val2;

            Console.WriteLine($"The sum is {sum}");

            if (val1 != val2)
            {
                Console.WriteLine("{0:D} is not equal to {1:D}", val1, val2);
            }
                 else
             {
                Console.WriteLine("{0:D} is equal to {1:D}", val1, val2);
             }
            if (val1 < val2)
            {
                Console.WriteLine("{0:D} is less than {1:D}", val1, val2);
            }
             else
             {
                 Console.WriteLine("{0:D} is greater than {1:D}", val1, val2);
              }


            if (val1 <= val2)
            {
                Console.WriteLine("{0:D} is less than or equal to {1:D}", val1,
                val2);
            }
             else
             {
               Console.WriteLine("{0:D} greater than equal to {1:D}", val1, val2);
             }


            Console.WriteLine("Enter float value :");
            val3 =Convert.ToDouble (Console.ReadLine());


            Console.WriteLine("Enter float value :");
            val4 =Convert.ToDouble (Console.ReadLine());

            total = val3 + val4;

            Console.WriteLine($"The total is {total}");

            if (val3 != val4)
            {
                Console.WriteLine("{0:F2} is not equal to {1:F2}", val3, val4);
            }
            else
            {
                Console.WriteLine("{0:F2} is equal to {1:F2}", val3, val4);
            }
            if (val3 < val4)
            {
                Console.WriteLine("{0:F2} is less than {1:F2}", val3, val4);
            }
            else
            {
                Console.WriteLine("{0:F2} is greater than {1:F2}", val3, val4);
            }


            if (val3 <= val4)
            {
                Console.WriteLine("{0:F2} is less than or equal to {1:F2}", val3,
                val4);
            }
            else
            {
                Console.WriteLine("{0:F2} greater than equal to {1:F2}", val3, val4);
            }


        }


    }
}

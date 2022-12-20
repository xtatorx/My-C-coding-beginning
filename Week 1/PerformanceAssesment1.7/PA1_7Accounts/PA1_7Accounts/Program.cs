/*  Brian Thorne
 *  12/15/2022
 *  CIS 214 Week 1 PA1.7
 *  */

public class AccountsTest
{

    static void Main(string[] args)
    {
        Console.WriteLine("\n Brian Thorne - Week1 PA Accounts");

        Accounts acct1 = new Accounts("John", "Jones", 1000);
        Accounts acct2 = new Accounts("Jane", "Jamison", 750);

        Console.WriteLine("Starting information for each employee");
        Console.WriteLine("\nName: {0} {1} \n Salary: ${2:F2}", acct1.FName,acct1.LName, acct1.MSalary);
        Console.WriteLine("\nName: {0} {1} \n Salary: ${2:F2}", acct2.FName, acct2.LName, acct2.MSalary);

        Console.WriteLine("\nUpdated Information for each employee");
        acct1.LName = "Smith";
        acct2.FName = "Janey";

        double salaryAmount = Convert.ToDouble(2500);
        acct1.SalaryAmount(salaryAmount);

        double salaryamount = Convert.ToDouble(2000);
        acct2.SalaryAmount(salaryamount);

        Console.WriteLine("\nName: {0} {1} \n Salary: ${2:F2}", acct1.FName, acct1.LName, acct1.MSalary);
        Console.WriteLine("\nName: {0} {1} \n Salary: ${2:F2}", acct2.FName, acct2.LName, acct2.MSalary);



    }


}

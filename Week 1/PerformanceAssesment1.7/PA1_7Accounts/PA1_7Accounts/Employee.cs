/* Brian Thorne
 * 12/15/2022
 * CIS 214 Week 1 PA17
 */

public class Accounts
{
    public string FName { get; set; }
    public string LName { get; set; }

    public double MSalary { get; private set; }

    public Accounts(string fname, string lname, double msalary)
    {
        FName = fname;
        LName = lname;
        
        if(msalary >= 1000)
        {
            MSalary = msalary;
        }

    }

    public void SalaryAmount(double amount)
    {
        if (amount >= 0)
        {
            MSalary = amount;
        }
       
    }


}

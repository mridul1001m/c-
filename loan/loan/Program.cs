using System;

class Loan
{
   
    public double CalculateEMI(double principal, double annualInterestRate, int months)
    {
        double monthlyInterestRate = annualInterestRate / 12 / 100;
        double emi = (principal * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, months))
                     / (Math.Pow(1 + monthlyInterestRate, months) - 1);
        return emi;
    }
}

class Program
{
    static void Main(string[] args)
    {
   
        Console.Write("Enter Loan Amount (Principal): ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Annual Interest Rate (in %): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Loan Tenure (in months): ");
        int months = Convert.ToInt32(Console.ReadLine());


        Loan loan = new Loan();
        double emi = loan.CalculateEMI(principal, rate, months);

       
        Console.WriteLine($"\nMonthly EMI is: {emi:F2}");
    }
}

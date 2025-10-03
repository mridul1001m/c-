using System;

class CurrencyConverter
{
    static void Main()
    {
        
        double usdRate = 0.012; // 
        double eurRate = 0.011; // 
        double gbpRate = 0.010; //

      
        Console.Write("Enter amount in Indian Rupees (INR): ");
        double inr = Convert.ToDouble(Console.ReadLine());

      
        double usd = inr * usdRate;
        double eur = inr * eurRate;
        double gbp = inr * gbpRate;

      
        Console.WriteLine($"\nConverted Amounts:");
        Console.WriteLine($"USD: {usd}");
        Console.WriteLine($"EUR: {eur}");
        Console.WriteLine($"GBP: {gbp}");
    }
}

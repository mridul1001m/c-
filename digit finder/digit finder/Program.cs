using System;

public class DigitFinder
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            number = Math.Abs(number);
        }

        int lastDigit = number % 10;
        int firstDigit = number;

        while (firstDigit >= 10)
        {
            firstDigit /= 10;
        }

        Console.WriteLine($"First: {firstDigit}");
        Console.WriteLine($"Last: {lastDigit}");
    }
}

using System;

using System;

namespace sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            string input = Console.ReadLine();
            int sum = 0;

            foreach (char digitchar in input)
            {
                if (char.IsDigit(digitchar))
                {
                    sum += int.Parse(digitchar.ToString());
                }
            }

            Console.WriteLine($"Sum: {sum}"); 
            Console.ReadLine();
        }
    }
}

using System;
class Program
{
    static void Main()
    {
        try
        {


            Console.WriteLine("enter the first input");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second input");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine("Result:" + result);

        }

        catch (DivideByZeroException)
        {
            Console.WriteLine("error cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("error please enter a valid number");
        }


        finally
        {
            Console.WriteLine("no code is here");
        }
    }
}
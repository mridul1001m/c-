using System;

public class Program
{
   
  delegate void Phonebook();

    
    public static void page1()
    {
        Console.WriteLine("translate");
    }

    public static void page2()
    {
        Console.WriteLine("cant say");
    }

    public static void Main()
    {
       
       Phonebook notify = page1;
        notify += page2;
        notify(); 
    }
}
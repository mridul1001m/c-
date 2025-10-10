using System;
class Program
{
    static void Main()
    {
        Stack<string> stacks = new Stack<string>();
        stacks.Push("alice");
        stacks.Push("is");
        stacks.Push("dumb");
        stacks.Push("why");
        stacks.Pop();

        Console.WriteLine("Stack contents after popping:");
        foreach (string item in stacks)
        {
            Console.WriteLine(item);
        }
    }
}
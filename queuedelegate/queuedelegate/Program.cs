class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("the");
        queue.Enqueue("book");
        queue.Enqueue("is");
        queue.Enqueue("fanta");

        queue.Dequeue();

        Console.WriteLine("Queue contents after dequeuing:");
        foreach (string item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
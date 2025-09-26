using(StreamWriter writer=new StreamWriter("example.txt"))
{
    writer.WriteLine("it is a bmw");
}

string content=File.ReadAllText("example.txt");
Console.WriteLine(content);
File.Copy("example.txt", "data.txt");
string read = File.ReadAllText("data.txt");
Console.WriteLine(read);
using System;
using System.Security.Cryptography.X509Certificates;
class Shape

{
    public virtual void draw()
    {
        Console.WriteLine("Drawing a shape");
    }
    public virtual void Erase()
    {
        Console.WriteLine("DRAWING A SHAPE");

    }
    public virtual void erase()
    {
        Console.WriteLine("erasing a shape");
    }
}
class circle : Shape
{
    public override void Erase()
    {
        Console.WriteLine("erasing a circle");
    }


}
class Triangle : Shape
{
    public override void draw()
    {


        Console.WriteLine("drawing a triangle");

    }

    public override void Erase()
    {
        Console.WriteLine("Erasing a traingle");

    }

}
class Square : Shape
{
    public override void draw()
    {

        Console.WriteLine("drawing a square");

    }
    public override void Erase()
    {
        Console.WriteLine("erasing a square");

    }

}
class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = { new circle(), new Triangle(), new Square() };
        foreach (Shape s in shapes)
        {
            s.draw();
            s.Erase();
        }
    }
}
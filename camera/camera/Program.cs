using System;

public interface Icamera
{
    void Capturephoto();
}

public interface IPrinter
{
    void PrintDocument(string document);
}

public class CameraDevice : Icamera
{
    public void Capturephoto()
    {
        Console.WriteLine("capturing a photo");
    }
}

public class PrinterDevice : IPrinter
{
    public void PrintDocument(string document)
    {
        Console.WriteLine($"printing document: {document}");
    }
}

public class Device : Icamera, IPrinter
{
    public void Capturephoto()
    {
        Console.WriteLine("device capturing the photo");
    }

    public void PrintDocument(string document)
    {
        Console.WriteLine($"device printing document: {document}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Icamera camera = new CameraDevice();
        camera.Capturephoto();

        IPrinter printer = new PrinterDevice();
        printer.PrintDocument("annual report");

        Device device = new Device();
        device.Capturephoto();
        device.PrintDocument("Project plan");
    }
}
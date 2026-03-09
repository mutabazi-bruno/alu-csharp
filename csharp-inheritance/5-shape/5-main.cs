using System;

/// <summary>Program class</summary>
class Program
{
    /// <summary>Main method</summary>
    /// <param name="args">Arguments</param>
    static void Main(string[] args)
    {
        Shape aShape = new Shape();

        try
        {
            Console.WriteLine("Area: {0}", aShape.Area());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}

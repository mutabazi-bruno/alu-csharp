using System;

/// <summary>Program class</summary>
class Program
{
    /// <summary>Main method</summary>
    /// <param name="args">Arguments</param>
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();

        aRect.Width = 7;
        aRect.Height = 4;

        Console.WriteLine("Area: {0}", aRect.Area());
        Console.WriteLine(aRect.ToString());
    }
}

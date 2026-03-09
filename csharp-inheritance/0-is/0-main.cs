using System;
using System.Collections.Generic;

/// <summary>Program class</summary>
class Program
{
    /// <summary>Main method</summary>
    /// <param name="args">Arguments</param>
    static void Main(string[] args)
    {
        var a = 10;
        var b = new List<int>();

        if (Obj.IsOfTypeInt(a))
            Console.WriteLine("{0} is of type int", nameof(a));
        else
            Console.WriteLine("{0} is NOT of type int", nameof(a));

        if (Obj.IsOfTypeInt(b))
            Console.WriteLine("{0} is of type int", nameof(b));
        else
            Console.WriteLine("{0} is NOT of type int", nameof(b));
    }
}

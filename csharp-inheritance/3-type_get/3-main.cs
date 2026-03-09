using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>Program class</summary>
class Program
{
    /// <summary>Main method</summary>
    /// <param name="args">Arguments</param>
    static void Main(string[] args)
    {
        var num = 10;
        var myList = new List<int>();

        Obj.Print(num);
        Console.WriteLine("-----------------");
        Obj.Print(myList);
    }
}

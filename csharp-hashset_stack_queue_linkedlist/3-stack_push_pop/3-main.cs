using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        aStack.Push("C");
        aStack.Push("HTML");
        aStack.Push("Javascript");
        aStack.Push("Python");
        aStack.Push("React");
        aStack.Push("Ruby");

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        Console.WriteLine(MyStack.Info(aStack));

        Console.WriteLine("Stack contains \"Javascript\": " + aStack.Contains("Javascript"));

        Console.WriteLine("------");

        for (int i = 0; i < 4; i++)
            aStack.Pop();
        aStack.Push("C#");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }
}

using System;
using System.Collections.Generic;

/// <summary>
/// List class
/// </summary>
public class List
{
    /// <summary>
    /// Creates and prints a list of integers of a given size
    /// </summary>
    /// <param name="size">The size of the list to create</param>
    /// <returns>The newly created list or null if size is negative</returns>
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> newList = new List<int>();

        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            Console.Write(i);
            if (i < size - 1)
                Console.Write(" ");
        }

        Console.WriteLine();
        return newList;
    }
}

using System;
using System.Collections.Generic;

/// <summary>
/// Array class
/// </summary>
class Array
{
    /// <summary>
    /// Retrieves an element from an array at a given position
    /// </summary>
    /// <param name="array">The array</param>
    /// <param name="index">The index position</param>
    /// <returns>The element at the given index, or -1 if index is out of range</returns>
    public static int elementAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }

        return myList[index];
    }
}

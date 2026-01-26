using System;
using System.Collections.Generic;

/// <summary>
/// List class
/// </summary>
public class List
{
    /// <summary>
    /// Finds all multiples of 2 in a list
    /// </summary>
    /// <param name="myList">The list to check</param>
    /// <returns>A list of booleans indicating divisibility by 2</returns>
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> result = new List<bool>();

        if (myList == null)
            return result;

        foreach (int num in myList)
        {
            result.Add(num % 2 == 0);
        }

        return result;
    }
}

using System;
using System.Collections.Generic;

/// <summary>
/// List class
/// </summary>
public class List
{
    /// <summary>
    /// Finds the biggest integer of a list
    /// </summary>
    /// <param name="myList">The list to search</param>
    /// <returns>The largest element or -1 if list is empty</returns>
    public static int MaxInteger(List<int> myList)
    {
        if (myList == null || myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int max = myList[0];

        for (int i = 1; i < myList.Count; i++)
        {
            if (myList[i] > max)
            {
                max = myList[i];
            }
        }

        return max;
    }
}

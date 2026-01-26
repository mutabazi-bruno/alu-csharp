using System;
using System.Collections.Generic;

/// <summary>
/// List class
/// </summary>
public class List
{
    /// <summary>
    /// Deletes the item at a specific position in a list
    /// </summary>
    /// <param name="myList">The list to modify</param>
    /// <param name="index">The index of the item to delete</param>
    /// <returns>The updated list</returns>
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (myList == null || index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        List<int> newList = new List<int>();

        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index)
            {
                newList.Add(myList[i]);
            }
        }

        myList.Clear();

        foreach (int item in newList)
        {
            myList.Add(item);
        }

        return myList;
    }
}

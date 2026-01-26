using System;
using System.Collections.Generic;

/// <summary>
/// Dictionary class
/// </summary>
public class Dictionary
{
    /// <summary>
    /// Prints a dictionary by ordered keys
    /// </summary>
    /// <param name="myDict">The dictionary to print</param>
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        if (myDict == null)
            return;

        List<string> keys = new List<string>();

        foreach (string key in myDict.Keys)
        {
            keys.Add(key);
        }

        keys.Sort();

        foreach (string key in keys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}

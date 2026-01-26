using System;
using System.Collections.Generic;

/// <summary>
/// Dictionary class
/// </summary>
public class Dictionary
{
    /// <summary>
    /// Returns the number of keys in a dictionary
    /// </summary>
    /// <param name="myDict">The dictionary to count keys from</param>
    /// <returns>The number of keys in the dictionary</returns>
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;

        if (myDict == null)
            return count;

        foreach (var key in myDict.Keys)
        {
            count++;
        }

        return count;
    }
}

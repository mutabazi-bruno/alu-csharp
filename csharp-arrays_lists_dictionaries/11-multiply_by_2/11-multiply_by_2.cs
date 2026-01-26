using System;
using System.Collections.Generic;

/// <summary>
/// Dictionary class
/// </summary>
public class Dictionary
{
    /// <summary>
    /// Returns a new dictionary with all values multiplied by 2
    /// </summary>
    /// <param name="myDict">The original dictionary</param>
    /// <returns>A new dictionary with doubled values</returns>
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        if (myDict == null)
            return newDict;

        foreach (KeyValuePair<string, int> entry in myDict)
        {
            newDict.Add(entry.Key, entry.Value * 2);
        }

        return newDict;
    }
}

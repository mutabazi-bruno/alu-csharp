using System;
using System.Collections.Generic;

/// <summary>
/// Dictionary class
/// </summary>
public class Dictionary
{
    /// <summary>
    /// Adds a key and value to a dictionary
    /// </summary>
    /// <param name="myDict">The dictionary to update</param>
    /// <param name="key">The key to add or update</param>
    /// <param name="value">The value to set</param>
    /// <returns>The updated dictionary</returns>
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        if (myDict == null)
            return myDict;

        if (myDict.ContainsKey(key))
        {
            myDict[key] = value;
        }
        else
        {
            myDict.Add(key, value);
        }

        return myDict;
    }
}

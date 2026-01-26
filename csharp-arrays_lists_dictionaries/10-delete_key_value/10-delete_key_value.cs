using System;
using System.Collections.Generic;

/// <summary>
/// Dictionary class
/// </summary>
public class Dictionary
{
    /// <summary>
    /// Deletes a key in a dictionary
    /// </summary>
    /// <param name="myDict">The dictionary to update</param>
    /// <param name="key">The key to delete</param>
    /// <returns>The updated dictionary</returns>
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        if (myDict == null)
            return myDict;

        if (myDict.ContainsKey(key))
        {
            myDict.Remove(key);
        }

        return myDict;
    }
}

using System;
using System.Collections.Generic;

/// <summary>
/// Dictionary class
/// </summary>
public class Dictionary
{
    /// <summary>
    /// Returns the key with the biggest integer value in a given dictionary
    /// </summary>
    /// <param name="myList">The dictionary to search</param>
    /// <returns>The key with the highest value or "None" if empty</returns>
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList == null || myList.Count == 0)
            return "None";

        string bestKey = null;
        int maxValue = int.MinValue;

        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > maxValue)
            {
                maxValue = entry.Value;
                bestKey = entry.Key;
            }
        }

        return bestKey;
    }
}

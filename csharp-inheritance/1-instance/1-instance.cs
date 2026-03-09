using System;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>Checks if obj is an instance of Array or inherits from Array</summary>
    /// <param name="obj">The object to check</param>
    /// <returns>True if obj is an instance of Array</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}

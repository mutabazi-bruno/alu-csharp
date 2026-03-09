using System;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>Checks if derivedType is a subclass of baseType</summary>
    /// <param name="derivedType">The derived type to check</param>
    /// <param name="baseType">The base type to check against</param>
    /// <returns>True if derivedType is a subclass of baseType</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}

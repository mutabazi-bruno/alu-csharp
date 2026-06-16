using System;

/// <summary>
/// A generic Queue class that provides basic type checking functionality.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
class Queue<T>
{
    /// <summary>
    /// Gets the name of the type T as it would be written in C# code.
    /// </summary>
    /// <returns>The type name as a string (e.g., "string", "double", "object").</returns>
    public string CheckType()
    {
        Type type = typeof(T);
        
        // Map common types to their C# keyword names
        if (type == typeof(string))
            return "string";
        if (type == typeof(int))
            return "int";
        if (type == typeof(double))
            return "double";
        if (type == typeof(float))
            return "float";
        if (type == typeof(long))
            return "long";
        if (type == typeof(short))
            return "short";
        if (type == typeof(byte))
            return "byte";
        if (type == typeof(sbyte))
            return "sbyte";
        if (type == typeof(uint))
            return "uint";
        if (type == typeof(ulong))
            return "ulong";
        if (type == typeof(ushort))
            return "ushort";
        if (type == typeof(bool))
            return "bool";
        if (type == typeof(char))
            return "char";
        if (type == typeof(decimal))
            return "decimal";
        if (type == typeof(object))
            return "object";
        
        // For other types, return the full name
        return type.FullName;
    }
}

/// <summary>
/// Main program class for testing the Queue generic class.
/// </summary>
class Program
{
    /// <summary>
    /// Main entry point of the application.
    /// </summary>
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();
        Queue<object> myObjQ = new Queue<object>();

        Console.WriteLine($"{nameof(myStrQ)} Queue Type: " + myStrQ.CheckType());
        Console.WriteLine($"{nameof(myObjQ)} Queue Type: " + myObjQ.CheckType());
    }
}

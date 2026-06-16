using System;

/// <summary>
/// A generic Queue class that provides basic type checking functionality.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
class Queue<T>
{
    /// <summary>
    /// Gets the name of the type T.
    /// </summary>
    /// <returns>The full type name as a string (e.g., "System.String", "System.Double").</returns>
    public string CheckType()
    {
        return typeof(T).FullName;
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

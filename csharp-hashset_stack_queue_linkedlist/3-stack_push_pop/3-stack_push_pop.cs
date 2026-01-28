using System;
using System.Collections.Generic;

/// <summary>
/// MyStack class
/// </summary>
class MyStack
{
    /// <summary>
    /// Returns information about a stack
    /// </summary>
    /// <param name="aStack">The stack to get info from</param>
    /// <returns>Info string about the stack</returns>
    public static string Info(Stack<string> aStack)
    {
        if (aStack.Count == 0)
        {
            return "Stack is empty";
        }
        else
        {
            return $"Number of items: {aStack.Count}\nTop item: {aStack.Peek()}";
        }
    }
}

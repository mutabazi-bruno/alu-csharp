using System;

/// <summary>
/// Array class
/// </summary>
class Array
{
    /// <summary>
    /// Creates and prints an array of integers of a given size
    /// </summary>
    /// <param name="size">The size of the array</param>
    /// <returns>The new array, or null if size is negative</returns>
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }

        int[] array = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            array[i] = i;
            if (i < size - 1)
                Console.Write(i + " ");
            else
                Console.WriteLine(i);
        }

        return array;
    }
}

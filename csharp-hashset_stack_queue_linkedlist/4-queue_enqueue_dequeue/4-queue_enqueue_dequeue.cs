using System;
using System.Collections.Generic;

/// <summary>
/// MyQueue class with queue operations
/// </summary>
class MyQueue
{
    /// <summary>
    /// Prints queue info, adds new item, and removes items up to search term
    /// </summary>
    /// <param name="aQueue">The queue to process</param>
    /// <param name="newItem">Item to add to the queue</param>
    /// <param name="search">Item to search for</param>
    /// <returns>Modified queue</returns>
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print number of items
        Console.WriteLine($"Number of items: {aQueue.Count}");

        // Print first item or "Queue is empty"
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }

        // Add new item to queue
        aQueue.Enqueue(newItem);

        // Check if queue contains search item
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        // If contains search, remove all items up to and including search
        if (containsSearch)
        {
            // Convert queue to array to process
            string[] items = aQueue.ToArray();
            
            // Clear the queue
            aQueue.Clear();
            
            // Find the index of search item
            int searchIndex = -1;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == search)
                {
                    searchIndex = i;
                    break;
                }
            }
            
            // Re-enqueue items after the search item
            for (int i = searchIndex + 1; i < items.Length; i++)
            {
                aQueue.Enqueue(items[i]);
            }
        }

        return aQueue;
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();
        
        myStrQ.Enqueued("Hello");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());
        
        myStrQ.Enqueued("World");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());
        
        Console.WriteLine("---------");
        
        Queue<float> myFloatQ = new Queue<float>();
        
        myFloatQ.Enqueued(4.2f);
        myFloatQ.Enqueued(4.2f);
        myFloatQ.Enqueued(4.2f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
        
        myFloatQ.Enqueued(4.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
    }
}

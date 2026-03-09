using System;

/// <summary>Program class</summary>
class Program
{
    /// <summary>Main method</summary>
    /// <param name="args">Arguments</param>
    static void Main(string[] args)
    {
        if (Obj.IsOnlyASubclass(typeof(Dog), typeof(Animal)))
            Console.WriteLine("Dog is a subclass of Animal");
        else
            Console.WriteLine("Dog is not a subclass of Animal");

        if (Obj.IsOnlyASubclass(typeof(Cat), typeof(Animal)))
            Console.WriteLine("Cat is a subclass of Animal");
        else
            Console.WriteLine("Cat is not a subclass of Animal");

        if (Obj.IsOnlyASubclass(typeof(Cat), typeof(Dog)))
            Console.WriteLine("Cat is a subclass of Dog");
        else
            Console.WriteLine("Cat is not a subclass of Dog");

        if (Obj.IsOnlyASubclass(typeof(Animal), typeof(Animal)))
            Console.WriteLine("Animal is a subclass of Animal");
        else
            Console.WriteLine("Animal is not a subclass of Animal");
    }
}

/// <summary>Animal class</summary>
class Animal
{
    // Empty class
}

/// <summary>Dog class</summary>
class Dog : Animal
{
    // Empty class
}

/// <summary>Cat class</summary>
class Cat : Animal
{
    // Empty class
}

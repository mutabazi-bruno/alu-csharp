using System;

/// <summary>
/// A generic Node class for use in a Queue data structure.
/// </summary>
/// <typeparam name="T">The type of value stored in the node.</typeparam>
class Node<T>
{
    /// <summary>
    /// The value stored in the node.
    /// </summary>
    public T value { get; set; }
    
    /// <summary>
    /// Reference to the next node in the queue.
    /// </summary>
    public Node<T> next { get; set; }
    
    /// <summary>
    /// Initializes a new instance of the Node class with the specified value.
    /// </summary>
    /// <param name="value">The value to store in the node.</param>
    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }
}

/// <summary>
/// A generic Queue class that stores nodes and provides enqueue and count operations.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
class Queue<T>
{
    /// <summary>
    /// Reference to the head (first) node in the queue.
    /// </summary>
    public Node<T> head { get; set; }
    
    /// <summary>
    /// Reference to the tail (last) node in the queue.
    /// </summary>
    public Node<T> tail { get; set; }
    
    /// <summary>
    /// The number of nodes currently in the queue.
    /// </summary>
    public int count { get; set; }
    
    /// <summary>
    /// Initializes a new instance of the Queue class.
    /// </summary>
    public Queue()
    {
        this.head = null;
        this.tail = null;
        this.count = 0;
    }
    
    /// <summary>
    /// Gets the name of the type T.
    /// </summary>
    /// <returns>The full type name as a string.</returns>
    public string CheckType()
    {
        return typeof(T).FullName;
    }
    
    /// <summary>
    /// Adds a new node with the specified value to the end of the queue.
    /// </summary>
    /// <param name="value">The value to enqueue.</param>
    public void Enqueued(T value)
    {
        Node<T> newNode = new Node<T>(value);
        
        if (this.head == null)
        {
            this.head = newNode;
        }
        else
        {
            this.tail.next = newNode;
        }
        
        this.tail = newNode;
        this.count++;
    }
    
    /// <summary>
    /// Returns the number of nodes currently in the queue.
    /// </summary>
    /// <returns>The count of nodes in the queue.</returns>
    public int Count()
    {
        return this.count;
    }
}

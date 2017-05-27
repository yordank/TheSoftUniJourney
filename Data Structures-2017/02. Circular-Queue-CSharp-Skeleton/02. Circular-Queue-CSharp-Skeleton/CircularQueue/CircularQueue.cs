using System;

public class CircularQueue<T>
{
    private const int DefaultCapacity = 4;

    public int Count { get; private set; }

    
    private T[] Elements { get; set; }

    private int startIndex { get; set; }

    private int endIndex { get; set; }

    public CircularQueue(int capacity = DefaultCapacity)
    {
        this.Elements = new T[capacity];

    }

    public void Enqueue(T element)
    {
        if (this.Count >= this.Elements.Length)
        {
            this.Resize();
        }

        this.Elements[this.endIndex] = element;
        this.endIndex = (this.endIndex + 1) % this.Elements.Length;
        this.Count++;

    }

    

    private void Resize()
    {
        var newElements = new T[2 * this.Elements.Length];
        this.CopyAllElements(newElements);
        this.Elements = newElements;
        this.startIndex = 0;
        this.endIndex = this.Count;
    }

    private void CopyAllElements(T[] resultArr)
    {
        int sourceIndex = this.startIndex;
        int destinationIndex = 0;

        for (int i = 0; i < this.Count; i++)
        {
            resultArr[destinationIndex] = this.Elements[sourceIndex];
            sourceIndex = (sourceIndex + 1) % this.Elements.Length;
            destinationIndex++;
        }


    }

    // Should throw InvalidOperationException if the queue is empty
    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("The queue is empty!");
        }

        var result = this.Elements[startIndex];
        this.startIndex = (this.startIndex + 1) % this.Elements.Length;
        this.Count--;
        return result;

    }

    public T[] ToArray()
    {
        var resultArr = new T[this.Count];
        CopyAllElements(resultArr);

        return resultArr;
    }
}


public class Example
{
    public static void Main()
    {

        CircularQueue<int> queue = new CircularQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        int first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-7);
        queue.Enqueue(-8);
        queue.Enqueue(-9);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-10);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");
    }
}

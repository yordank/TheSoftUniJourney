using System;
using System.Collections;
using System.Collections.Generic;

public class ListNode<T>
{
    public T Value { get; set; }
    public ListNode<T> NextNode { get; set; }
    public ListNode<T> PrevNode { get; set; }
    public ListNode(T value)
    {
        this.Value = value;
    }
}
public class DoublyLinkedList<T> : IEnumerable<T>
{
    public int Count { get; private set; }

    public ListNode<T> Head { get; set; }
    public ListNode<T> Tail { get; set; }


    public void AddFirst(T element)
    {
        if(this.Count==0)
        {
            this.Head = this.Tail = new ListNode<T>(element);
        }
        else
        {
            var newHead = new ListNode<T>(element);
            newHead.NextNode = this.Head;
            this.Head.PrevNode = newHead;
            this.Head = newHead;
        }

        this.Count++;

    }



    public void AddLast(T element)
    {
        if (this.Count == 0)
        {
            this.Head = this.Tail = new ListNode<T>(element);

        }

        else
        {
            var newTail = new ListNode<T>(element);
            newTail.PrevNode = this.Tail;
            newTail.NextNode = null;
            this.Tail.NextNode = newTail;
            this.Tail = newTail;

        }
        this.Count++;

    }

    public T RemoveFirst()
    {
        if(this.Count==0)
        {
            throw new InvalidOperationException("List Empty");
        }

        var firstElement = this.Head.Value;

        this.Head = this.Head.NextNode;

        if(this.Head!=null)
        {
            this.Head.PrevNode.NextNode=null;
            this.Head.PrevNode = null;
        }

        else
        {
            this.Tail = null;
        }

        this.Count--;

        return firstElement;

    }

    public T RemoveLast()
    {
        if(this.Count==0)
        {
            throw new InvalidOperationException("List Empty");
        }

        var lastElement = this.Tail.Value;

        this.Tail = this.Tail.PrevNode;

        if(this.Tail!=null)
        {
          //  this.Tail.NextNode.PrevNode = null;
            this.Tail.NextNode = null;
           
        }
        
        else
        {
            this.Head = null;
        }

        this.Count--;

        return lastElement;

    }

    public void ForEach(Action<T> action)
    {
        var currentNode = this.Head;
        while(currentNode!=null)
        {
            action(currentNode.Value);
            currentNode = currentNode.NextNode;
        }

    }

    public IEnumerator<T> GetEnumerator()
    {
        var currentNode = this.Head;

        while(currentNode!=null)
        {
            yield return currentNode.Value;
            currentNode = currentNode.NextNode;
        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public T[] ToArray()
    {
        var arr = new T[this.Count];

        var currentNode = this.Head;
        int currentIndex = 0;
        while(currentNode!=null)
        {
            arr[currentIndex] = currentNode.Value;
            currentIndex++;
            currentNode = currentNode.NextNode;
        }

        return arr;

    }
}


class Example
{
    static void Main()
    {
        var list = new DoublyLinkedList<int>();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.AddLast(5);
        list.AddFirst(3);
        list.AddFirst(2);
        list.AddLast(10);
        list.AddLast(12);
        Console.WriteLine("Count = {0}", list.Count);

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveFirst();
        list.RemoveLast();
        list.RemoveFirst();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveLast();
        //list.RemoveFirst();
        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");
    }
}

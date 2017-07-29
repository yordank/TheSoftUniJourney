using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedList<T> : IEnumerable<T> 
    where T :IComparable
{
    public class Node 
        
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
        public Node Next { get; set; }

         
    }

    public Node Head { get;private set; }
    public Node Tail { get; private set; }

    public int Count { get; private set; }

    public void AddFirst(T item)
    {
        Node old = Head;
        this.Head = new Node(item);
        this.Head.Next = old;

        if (IsEmpty())
        {
            Tail = Head;    
        }

        Count++;

    }

    public void Remove(T value)
    {
        Node current = this.Head;

        if (current == null)
            return;

        if (current.Value.CompareTo(value) == 0)
        {
            Head = Head.Next;
            Count--;
            return;
        }

        while (current.Next != null && current.Next.Value.CompareTo(value)!=0)
        {
            
            current = current.Next;
        }

        if (current.Next == null)
            return;

        if (current.Next.Next == null)
        {
            this.RemoveLast();
            Count--;
            return;
        }
        
        current.Next = current.Next.Next;
        Count--;

    }

    private bool IsEmpty()
    {
        return Count == 0;
    }

    public void AddLast(T item)
    {
        Node old = this.Tail;
        this.Tail = new Node(item);

        if (IsEmpty())
        {
            this.Head = this.Tail;
        }
        else
        {
            old.Next = this.Tail;
        }

        this.Count++;


    }

    public T RemoveFirst()
    {
        if (this.IsEmpty())
        {
            throw new InvalidOperationException();
        }

        T item = this.Head.Value;

        this.Head = this.Head.Next;

        this.Count--;

        if (this.IsEmpty())
        {
            this.Tail = null;
        }

        return item;
    }

    public T RemoveLast()
    {
        if (this.IsEmpty())
        {
            throw new InvalidOperationException();
        }

        T item = this.Tail.Value;

        if (this.Count == 1)
        {
            this.Head = this.Tail = null;
        }
        else
        {
            Node newTail = this.GetSecondToLast();
            newTail.Next = null;
            this.Tail = newTail;
        }

        this.Count--;

        return item;
    }

    private Node GetSecondToLast()
    {
        var current = this.Head;

        while (current.Next.Next != null)
        {
            current = current.Next;
        }
        return current;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = this.Head;

        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    
}

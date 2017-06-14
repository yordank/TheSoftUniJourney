using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

public class FirstLastList<T> : IFirstLastList<T> where T : IComparable<T>
{
    public OrderedBag<LinkedListNode<T>> ItemsByOrder { get; set; }

    public OrderedBag<LinkedListNode<T>> ItemsByOrderReversed { get; set; }
    public LinkedList<T> ListItemsbyInsertion { get; set; }

     
    public FirstLastList()
    {
        this.ListItemsbyInsertion = new LinkedList<T>();

        this.ItemsByOrder = new OrderedBag<LinkedListNode<T>>((x, y) => x.Value.CompareTo(y.Value));

        this.ItemsByOrderReversed = new OrderedBag<LinkedListNode<T>>((x, y) => -x.Value.CompareTo(y.Value));

    }
    public int Count
    {
        get
        {
            return this.ListItemsbyInsertion.Count;
        }
    }

    public void Add(T element)
    {
        var node = new LinkedListNode<T>(element);
        this.ItemsByOrder.Add(node);
        this.ListItemsbyInsertion.AddLast(element);
        this.ItemsByOrderReversed.Add(node);
    }

    public void Clear()
    {
        this.ListItemsbyInsertion.Clear();
        this.ItemsByOrder.Clear();
        this.ItemsByOrderReversed.Clear();

    }

    public IEnumerable<T> First(int count)
    {
        if (count > this.Count || count<0)
        {
            throw new ArgumentOutOfRangeException("no elements!!!");
        }

        else
        {
            return ListItemsbyInsertion.Take<T>(count);

        }



    }

    public IEnumerable<T> Last(int count)
    {
        if (count > this.Count)
        {
            throw new ArgumentOutOfRangeException("no elements!!!");
        }

        else
        {
            for (int i = 0; i < count; i++)
            {
                yield return ListItemsbyInsertion.ElementAt(this.Count-1-i);
            }


        }


    }

    public IEnumerable<T> Max(int count)
    {
        if (count > this.Count)
        {
            throw new ArgumentOutOfRangeException();
        }

        
        return this.ItemsByOrderReversed.Take(count).Select(x => x.Value);
       
    }

    public IEnumerable<T> Min(int count)
    {
        if (count > this.Count)
        {
            throw new ArgumentOutOfRangeException();
        }

        

       return this.ItemsByOrder.Take(count).Select(x=>x.Value); ;
    }

    public int RemoveAll(T element)
    {
        var node = new LinkedListNode<T>(element);

        var range=ItemsByOrder.Range(node, true, node, true);

        foreach (var item in range)
        {
            ListItemsbyInsertion.Remove(item.Value);
        }

        var count = ItemsByOrder.RemoveAllCopies(node);
        ItemsByOrderReversed.RemoveAllCopies(node);


        return count;

    }
}

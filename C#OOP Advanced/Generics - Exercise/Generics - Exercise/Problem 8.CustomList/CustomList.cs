using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CustomList<T>
    where T : IComparable
{
    public CustomList()
    {
        this.List = new List<T>();
    }

    private List<T> list;

    public List<T> List
    {
        get
        {
            return list;
        }

        set
        {
            list = value;
        }
    }

    public void Add(T element)
    {
        this.List.Add(element);
    }

    public T Remove(int index)
    {
        var elem = List.ElementAt(index);

        this.List.RemoveAt(index);

        return elem;

    }

    public bool Contains(T element)
    {
        return this.List.Contains(element);
    }

    public void Swap(int index1, int index2)
    {
        var temp = this.List[index1];
        this.List[index1] = this.List[index2];
        this.List[index2] = temp;
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;

        foreach (var item in this.List)
        {
            if (item.CompareTo(element)>0)
            {
                count++;
            }
        }

        return count;
    }

    public T Max()
    {
        return this.List.Max();
    }

    public T Min()
    {
        return this.List.Min();
    }
}


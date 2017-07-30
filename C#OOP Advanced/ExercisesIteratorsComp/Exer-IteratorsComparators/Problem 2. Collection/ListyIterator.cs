using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ListyIterator<T>:IEnumerable<T>
{
    public List<T> List { get; set; }
    public int Index { get; set; }
    public ListyIterator(ICollection<T>collection)
    {
        this.List = new List<T>(collection);
        Index = 0;
    }

    public bool Move()
    {
        if(this.HasNext())
        {
            this.Index++;

            return true;
        }

        return false;

    }

    public void Print()
    {
        if (List.Count == 0)
            throw new Exception("Invalid Operation!");

        Console.WriteLine(List[this.Index]);

    }

    public bool HasNext()
    {
        if (this.Index + 1 < List.Count)
        {
            return true;
        }

        return false;
    }
    public void PrintAll()
    {
        foreach (var item in this)
        {
            Console.Write(item+" ");
        }
        Console.WriteLine();
    }
    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in this.List)
        {
           yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}


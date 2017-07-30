using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Lake : IEnumerable<int>
{
    public Lake(List<int>list)
    {
        this.List = list;
    }
    public List<int> List { get; set; }


    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < List.Count; i=i+2)
        {
            yield return List[i]; 
        }

        Stack<int> stack = new Stack<int>();

        for (int i = 1; i < List.Count; i = i + 2)
        {
            stack.Push(List[i]);
        }

        while(stack.Count()!=0)
        {
            yield return stack.Pop();
        }

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}


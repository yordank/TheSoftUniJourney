using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
    public class StackOfStrings
    {
        public StackOfStrings()
        {
            data = new List<string>();
        }
         
        private List<string> data;
        public void Push(string item)
        {
            data.Insert(0, item);
        }

        public string Pop()
        {
            var result = data[0];
            data.RemoveAt(0);
            return result;
        }
        public string Peek()
        {
            return data[0];
        }

        public bool IsEmpty()
        {
            return data.Count() == 0;
        }
    }
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy.Core
{
    public class Node<T>
    {
        public Node(T elem)
        {
            this.Value = elem;
            this.Children = new List<Node<T>>();
            this.Parent = null;
        }
        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public Node<T>  Parent { get; set; }

    }
}

namespace Hierarchy.Core
{
    using System;
    using System.Collections.Generic;
    using System.Collections;

    public class Hierarchy<T> : IHierarchy<T>
    {

        public Node<T> root { get; set; }

        public Dictionary<T,Node<T>> NodesByValues { get; set; }
        public Hierarchy(T root)
        {
            this.root = new Node<T>(root);

            NodesByValues = new Dictionary<T, Node<T>>();

            NodesByValues.Add(root, this.root);

        }

        public int Count
        {
            get
            {
                return NodesByValues.Count;
                
            }

        }

        public void Add(T element, T child)
        {
            if(!NodesByValues.ContainsKey(element))
            {
                throw new ArgumentException("Parrent not exists!!!");
            }

            if (NodesByValues.ContainsKey(child))
            {
                throw new ArgumentException("Child exists!!!");
            }

            Node<T> newChildNode = new Node<T>(child);

            NodesByValues.Add(child, newChildNode);

            var parent = NodesByValues[element];

            newChildNode.Parent = parent;

            parent.Children.Add(newChildNode);

        }

        public void Remove(T element)
        {
            if (!NodesByValues.ContainsKey(element))
            {
                throw new ArgumentException("element not exist!!!");
            }
            var node = NodesByValues[element];

            if (node.Parent == null)
            {
                throw new InvalidOperationException("cannon remove the root!!!");
            }


            var parent = node.Parent;

            parent.Children.AddRange(node.Children);

            parent.Children.Remove(node);

            foreach (var nodes in node.Children)
            {
                nodes.Parent = parent;
            }

            NodesByValues.Remove(element);

        }

        public IEnumerable<T> GetChildren(T item)
        {
            if (!NodesByValues.ContainsKey(item))
            {
                throw new ArgumentException("element not exists!!!");
            }

            var node = NodesByValues[item];


            for (int i = 0; i < node.Children.Count; i++)
            {
                yield return node.Children[i].Value;
            }


        }

        public T GetParent(T item)
        {
            if (!NodesByValues.ContainsKey(item))
            {
                throw new ArgumentException("element not exist!!!");
            }

            

            var node = NodesByValues[item];

            if (node.Parent == null)
                return default(T);

            return node.Parent.Value;

        }

        public bool Contains(T value)
        {
            return NodesByValues.ContainsKey(value);
        }

        public IEnumerable<T> GetCommonElements(Hierarchy<T> other)
        {

            var hashset1 = new HashSet<T>(this.NodesByValues.Keys);

            var hashset2 = new HashSet<T>(this.NodesByValues.Keys);

            hashset1.IntersectWith(other);

            return hashset1;

        }

        public IEnumerator<T> GetEnumerator()
        {
            Queue<Node<T>> q = new Queue<Node<T>>();

            q.Enqueue(this.root);

            while (q.Count>0)
            {
                Node<T> currentNode = q.Dequeue();

                yield return currentNode.Value;

                for (int i = 0; i < currentNode.Children.Count; i++)
                {
                    q.Enqueue(currentNode.Children[i]);
                }

            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
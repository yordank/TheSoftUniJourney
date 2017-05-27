using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
    public class LinkedStack<T>
    {
        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element)
        {
            Node<T> newNode = new Node<T>(element,null);

            newNode.NextNode = this.firstNode;

            this.firstNode = newNode;

            this.Count++;


        }

        public T Pop()
        {
            if (this.Count == 0)
                throw new InvalidOperationException();
            else
            {

                T elem = this.firstNode.value;

                this.firstNode = this.firstNode.NextNode;


                this.Count--;

                return elem;

            }

        }

        public T[] ToArray()
        {
            Node<T> firstNode = this.firstNode;

            T[] arr = new T[Count];

            for (int i = 0; i < Count; i++)
            {
                arr[i] = firstNode.value;

                firstNode = firstNode.NextNode;

            }

            return arr;

        }
        private class Node<T>
        {
            public T value;
            public Node<T> NextNode { get; set; }

            public Node(T value, Node<T> nextNode = null)
            {
                this.value = value;
                this.NextNode = nextNode;
            }

        }
    }

 

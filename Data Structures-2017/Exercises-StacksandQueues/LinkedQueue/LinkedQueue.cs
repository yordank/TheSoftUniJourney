using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
    public class LinkedQueue<T>
    {

        public int Count { get; private set; }

        public QueueNode<T> Head { get; set; }

        public QueueNode<T> Tail { get; set; }

        public void Enqueue(T element)
        {
            QueueNode <T>newNode= new QueueNode<T>(element);
             

            if (this.Count == 0)
            {
                this.Head = newNode;
                this.Tail = newNode;
                 
            }
            else
            {
                this.Tail.NextNode = newNode;

                newNode.PrevNode = this.Tail;

                this.Tail = newNode;

            }

            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("The queue is empty");

            else
            {
                if (this.Count == 1)
                {
                    T value = this.Head.Value;

                    this.Head = null;

                    this.Tail = null;

                    this.Count--;

                    return value;

                }

                else
                {
                    T value = this.Head.Value;

                    this.Head = this.Head.NextNode;

                    this.Count--;

                    return value;
                }

            }

        }

        public T[] ToArray()
        {
            T[] arr = new T[Count];

            var node = Head;

            for (int i = 0; i < this.Count; i++)
            {
                arr[i] = node.Value;

                node = node.NextNode;
            }

            return arr;
        }

        public class QueueNode<T>
        {
            public QueueNode()
            {
                this.NextNode = null;
                this.PrevNode = null;
            }
            public QueueNode(T element)
            {
                this.NextNode = null;
                this.PrevNode = null;
                this.Value = element;
            }
            public T Value { get; private set; }
            public QueueNode<T> NextNode { get; set; }
            public QueueNode<T> PrevNode { get; set; }
        }
    }

 

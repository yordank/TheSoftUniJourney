using System;

public class ArrayStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }

        private const int InitialCapacity = 16;

    
        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public void Push(T element)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }

            this.elements[this.Count] = element;
             
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }

            this.Count--;

            return this.elements[this.Count];

        }

        public T[] ToArray()
        {
            var newArray = new T[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.elements[this.Count - 1 - i];
            }
            return newArray;

    }

         

        private void Grow()
        {
            var newElements = new T[2 * this.elements.Length];
            Array.Copy(this.elements, 0, newElements, 0, this.Count);
            this.elements = newElements;
             
        }
    }

 

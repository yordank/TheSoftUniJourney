using System;

namespace AvlTreeLab
{
    public class Node<T> where T:IComparable<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }
        public T Value { get; set; }

        private Node<T> leftChild;

        private Node<T> rightChild;


        public Node<T> LeftChild
        {
            get
            {
                return this.leftChild;
            }
            set
            {
                if(value!=null)
                {
                    value.Parent = this;
                }

                this.leftChild = value;
            }

        }
        public Node<T> RightChild
        {
            get
            {
                return this.rightChild;
            }
            set
            {
                if (value != null)
                {
                    value.Parent = this;
                }

                this.rightChild = value;
            }

        }

        public Node<T> Parent { get; set; }


        public int BalanceFactor { get; set; }

        

        public bool isLeftChild
        {
            get
            {
                return this.Parent.LeftChild == this;
            }
        }

        public bool isRightChild
        {
            get
            {
                return this.Parent.RightChild == this;
            }

        }

        public int ChildrenCount
        {
            get
            {
                int leftChild = this.LeftChild != null ? 1 : 0;
                int RightChild = this.RightChild != null ? 1 : 0;

                return leftChild + RightChild;
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }

    }
}


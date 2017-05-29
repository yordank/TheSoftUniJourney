using System;

 
public class BinaryTree<T>
{
    public T Value { get; set; }

    public BinaryTree<T> LeftChild { get; set; }

    public BinaryTree<T> RighChild { get; set; }

    public BinaryTree(T value, BinaryTree<T> leftChild = null, BinaryTree<T> rightChild = null)
    {

        this.Value = value;
        this.LeftChild = leftChild;
        this.RighChild = rightChild;
    }

    public void PrintIndentedPreOrder(int indent = 0)
    {
        Console.Write(new string(' ', 2 * indent));
        Console.WriteLine(this.Value);

        if (this.LeftChild != null)
        {
            this.LeftChild.PrintIndentedPreOrder(indent + 1);
        }

        if (this.RighChild != null)
        {
            this.RighChild.PrintIndentedPreOrder(indent + 1);
        }


    }

    public void EachInOrder(Action<T> action)
    {
        if (this.LeftChild != null)
        {
            this.LeftChild.EachInOrder(action);
        }

        action(this.Value);

        if (this.RighChild != null)
        {
            this.RighChild.EachInOrder(action);
        }


    }

    public void EachPostOrder(Action<T> action)
    {
        if (this.LeftChild != null)
        {
            this.LeftChild.EachPostOrder(action);
        }

        if (this.RighChild != null)
        {
            this.RighChild.EachPostOrder(action);
        }

        action(this.Value);

    }
}
 
using System;

public class AVL<T> where T : IComparable<T>
{
    private Node<T> root;

    public Node<T> Root
    {
        get
        {
            return this.root;
        }
    }

    public bool Contains(T item)
    {
        var node = this.Search(this.root, item);
        return node != null;
    }

    public void Insert(T item)
    {
        this.root = this.Insert(this.root, item);
    }

    public void EachInOrder(Action<T> action)
    {
        this.EachInOrder(this.root, action);
    }

    private Node<T> Insert(Node<T> node, T item)
    {
        if (node == null)
        {
            return new Node<T>(item);
        }

        int cmp = item.CompareTo(node.Value);
        if (cmp < 0)
        {
            node.Left = this.Insert(node.Left, item);
        }
        else if (cmp > 0)
        {
            node.Right = this.Insert(node.Right, item);
        }

        UpdateHeightOfNode(node);
        
        return Balance(node); ;
    }

    private static void UpdateHeightOfNode(Node<T> node)
    {
        node.Height = Math.Max(getHeight(node.Left), getHeight(node.Right)) + 1;

    }

    private static int getHeight(Node<T>node)
    {

        if (node == null)
        {
            return 0;
        }

        return node.Height;

    }

    private Node<T> Search(Node<T> node, T item)
    {
        if (node == null)
        {
            return null;
        }

        int cmp = item.CompareTo(node.Value);
        if (cmp < 0)
        {
            return Search(node.Left, item);
        }
        else if (cmp > 0)
        {
            return Search(node.Right, item);
        }

        return node;
    }

    private void EachInOrder(Node<T> node, Action<T> action)
    {
        if (node == null)
        {
            return;
        }

        this.EachInOrder(node.Left, action);
        action(node.Value);
        this.EachInOrder(node.Right, action);
    }

    private static Node<T> RotateRight(Node<T>node)
    {
        var left = node.Left;

        node.Left = node.Left.Right;

        left.Right = node;

        UpdateHeightOfNode(node);

        return left;
    }

    private static Node<T> RotateLeft(Node<T>node)
    {
        var right = node.Right;

        node.Right = node.Right.Left;

         right.Left = node;

        UpdateHeightOfNode(node);

        return right;
    }

    private static Node<T> Balance(Node<T>node)
    {
        int balance = Height(node.Left) - Height(node.Right);

        if (balance < -1)
        {
            balance = getHeight(node.Right.Left) - getHeight(node.Right.Right);

            if (balance <= 0)
            {
                return RotateLeft(node);
            }
            else
            {
                node.Right = RotateRight(node.Right);
                UpdateHeightOfNode(node.Right);
                return RotateLeft(node);
            }

        }

        else if (balance > 1)
        {
            balance = getHeight(node.Left.Left) - getHeight(node.Left.Right);

            if (balance >= 0)
            {
                return RotateRight(node);
            }
            else
            {
                node.Left = RotateLeft(node.Left);
                UpdateHeightOfNode(node.Left);
                return RotateRight(node);
            }
        }

        return node;

    }

    private static int Height(Node<T> node)
    {
        if (node == null)
            return 0;
        return node.Height;
    }
}

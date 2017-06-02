﻿using System;
using System.Collections.Generic;

public class BinarySearchTree<T> where T : IComparable<T>
{

    private Node root { get; set; }

    public class Node
    {
        public Node(T value)
        {
            this.Value = value;
            
        }

        public T Value { get; set; }
        public Node Left { get; set; }

        public Node Right { get; set; }



    }

    public BinarySearchTree(Node root)
    {
        this.Copy(root);
    }

    public BinarySearchTree()
    {
        
    }

    private void Copy(Node node)
    {
        if (node == null)
        {
            return;
        }

        this.Insert(node.Value);
        this.Copy(node.Left);
        this.Copy(node.Right);

    }

    public void Insert(T value)
    {
        if (this.root == null)
        {
            this.root = new Node(value);
            return;
        }

        Node parent = null;
        Node current = this.root;
        while (current != null)
        {
            if (value.CompareTo(current.Value) < 0)
            {
                parent = current;
                current = current.Left;
               
            }

            else if (value.CompareTo(current.Value) > 0)
            {
                parent = current;
                current = current.Right;
               
            }
            else
            {
                break;
            }
        }

        Node newNode = new Node(value);

        if (value.CompareTo(parent.Value) < 0)
        {
            parent.Left = newNode;
        }
        else
        {
            parent.Right = newNode;
        }

    }

    public bool Contains(T value)
    {
        Node current = this.root;

        while (current != null)
        {
            if (value.CompareTo(current.Value) < 0)
            {
                current = current.Left;
            }   
         
            else if (value.CompareTo(current.Value) > 0)
            {
                current = current.Right;
            }
            else
            {
                break;
            }

        }

        return current != null;

    }

    public void DeleteMin()
    {
        if (this.root == null)
        {
            return;
        }

        Node parent = null;

        Node min = this.root;

        while (min.Left != null)
        {
            parent = min;
            min = parent.Left;
        }

        if (parent == null)
        {
            this.root = min.Right;
        }
        else
        {
            parent.Left = min.Right;
        }

    }

   
    public BinarySearchTree<T> Search(T item)
    {
        Node current = this.root;

        while (current != null)
        {
            if (item.CompareTo(current.Value) < 0)
            {
                current = current.Left;
            }

            else if (item.CompareTo(current.Value) > 0)
            {
                current = current.Right;
            }
            else
            {
                if (item.CompareTo(current.Value) == 0)
                {
                    return new BinarySearchTree<T>(current);
                }

                break;
            }
        }

        return new BinarySearchTree<T>(current);

    }

    public IEnumerable<T> Range(T startRange, T endRange)
    {
        Queue<T> queue = new Queue<T>();

        this.Range(this.root, queue, startRange, endRange);

        return queue;
    }

    private void Range(Node node, Queue<T> queue, T startRange, T endRange)
    {
        if (node == null)
        {
            return;
        }

        int nodeInLowerRange = startRange.CompareTo(node.Value);

        int nodeInHigherRange = endRange.CompareTo(node.Value);

        if (nodeInLowerRange < 0)
        {
            this.Range(node.Left, queue, startRange, endRange);
        }

        if (nodeInLowerRange <= 0 && nodeInHigherRange >= 0)
        {
            queue.Enqueue(node.Value);
        }

        if (nodeInHigherRange > 0)
        {
            this.Range(node.Right , queue, startRange, endRange);
        }

    }

    public void EachInOrder(Action<T> action)
    {

        Node current = this.root;

        if(current!=null)
        DFS(action,current);



    }

    private void DFS(Action<T> action, Node current)
    {
        if(current.Left!=null)
            DFS(action, current.Left);

        action(current.Value);

        if (current.Right != null)
            DFS(action, current.Right);

    }
}

public class Launcher
{
    public static void Main(string[] args)
    {
        
    }
}

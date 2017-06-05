using System;
using System.Collections.Generic;

public class BinarySearchTree<T> : IBinarySearchTree<T> where T:IComparable
{
    private Node root;

     
    private Node FindElement(T element)
    {
        Node current = this.root;


        while (current != null)
        {
            if (current.Value.CompareTo(element) > 0)
            {
                current = current.Left;
            }
            else if (current.Value.CompareTo(element) < 0)
            {
                current = current.Right;
            }
            else
            {
                break;
            }
        }

        return current;
    }

    private Node FindParent(T element)
    {
        Node current = this.root;

        Node parent=null;

        while (current != null)
        {
            if (current.Value.CompareTo(element) > 0)
            {
                parent = current;
                current = current.Left;
            }
            else if (current.Value.CompareTo(element) < 0)
            {
                parent = current;
                current = current.Right;
            }
            else
            {
                break;
            }
        }

        return parent;
    }

    private void PreOrderCopy(Node node)
    {
        if (node == null)
        {
            return;
        }

        this.Insert(node.Value);
        this.PreOrderCopy(node.Left);
        this.PreOrderCopy(node.Right);
    }

    private Node Insert(T element, Node node)
    {
        if (node == null)
        {
            node = new Node(element);
        }
        else if (element.CompareTo(node.Value) < 0)
        {
            node.Left = this.Insert(element, node.Left);
        }
        else if (element.CompareTo(node.Value) > 0)
        {
            node.Right = this.Insert(element, node.Right);
        }

        node.Count=1+this.Count(node.Left)+this.Count(node.Right);

        return node;
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
            this.Range(node.Right, queue, startRange, endRange);
        }
    }
    
    private void EachInOrder(Node node, Action<T> action)
    {
        if (node == null)
        {
            return;
        }

        this.EachInOrder(node.Left, action);
        action(node.Value);
        this.EachInOrder(node.Right, action);
    }

    private BinarySearchTree(Node node)
    {
        this.PreOrderCopy(node);
    }

    public BinarySearchTree()
    {
    }
    
    public void Insert(T element)
    {
        
        this.root = this.Insert(element, this.root);
    }
    
    public bool Contains(T element)
    {
        Node current = this.FindElement(element);

        return current != null;
    }

    public void EachInOrder(Action<T> action)
    {
        this.EachInOrder(this.root, action);
    }

    public BinarySearchTree<T> Search(T element)
    {
        Node current = this.FindElement(element);

        return new BinarySearchTree<T>(current);
    }

    public void DeleteMin()
    {
        if (this.root == null)
        {
            throw new InvalidOperationException("tree is empty");


        }

        //if (this.root == null)
        //{
        //    return;
        //}

        //Node current = this.root;

        //Node parent = null;

        //while (current.Left != null)
        //{
        //    parent = current;
        //    current = current.Left;
        //}

        //if (parent == null)
        //{
        //    this.root = this.root.Right;
        //}
        //else
        //{
        //    parent.Left = current.Right;
        //}

        this.root = this.DeleteMin(this.root);


    }

    private Node DeleteMin(Node node)
    {

        if (node.Left == null)
        {
            return node.Right;
        }

        node.Left = this.DeleteMin(node.Left);

        node.Count--;

        return node;

    }

    public IEnumerable<T> Range(T startRange, T endRange)
    {
        Queue<T> queue = new Queue<T>();

        this.Range(this.root, queue, startRange, endRange);

        return queue;
    }

    public void Delete(T element)
    {
        if (this.root == null)
        {
            throw new InvalidOperationException("Tree is empty");
        }

         

        var cuurentNode = this.root;

        var parentNode = this.FindParent(element);

        var node = this.FindElement(element);

        if (node.Left == null && node.Right==null)
        {
            if (parentNode == null)
            {
                this.root = null;
            }

            else
            {
                if (parentNode.Left.Value.CompareTo(element) == 0)
                {
                    parentNode.Left = null;
                }

                else if (parentNode.Right.Value.CompareTo(element) == 0)
                {
                    parentNode.Right = null;
                }

            }

        }

    }

    public void DeleteMax()
    {
        if (this.root == null)
        {
            throw new InvalidOperationException("tree is empty");

             
        }

        //Node current = this.root;

        //Node parent = null;

        //while (current.Right != null)
        //{
        //    parent = current;
        //    current = current.Right;
        //}

        //if (parent == null)
        //{
        //    this.root = this.root.Left;
        //}
        //else
        //{
        //    parent.Right = current.Left;
        //}

        this.root = this.DeleteMax(this.root);

    }

    private Node DeleteMax(Node node)
    {

        if (node.Right == null)
        {
            return node.Left;
        }

        node.Right= this.DeleteMax(node.Right);

        node.Count--;

        return node;


    }

    public int Count()
    {
        //Stack<Node> stack = new Stack<Node>();

        //stack.Push(root);


        //int count = 0;


        //while (stack.Count > 0)
        //{
        //    count++;
        //    Node node = stack.Pop();

        //    if (node.Left != null)
        //    {
        //        stack.Push(node.Left);
        //    }

        //    if (node.Right != null)
        //    {
        //        stack.Push(node.Right);
        //    }

        //}

        //return count;

        return this.Count(this.root);

    }

    private int Count(Node node)
    {
        if (node == null)
        {
            return 0;
        }

        return node.Count;
    }

    public int Rank(T element)
    {
        return this.Rank(element,this.root);
    }

    private int Rank(T element, Node node)
    {
        if (node == null)
        {
            return 0;
        }

        int compare = element.CompareTo(node.Value);

        if (compare < 0)
        {
            return this.Rank(element, node.Left);
        }

        if (compare > 0)
        {
            return 1 + this.Rank(element, node.Left) + this.Rank(element, node.Right);
        }

        return this.Rank(element, node.Left);

    }

    public T Select(int rank)
    {
        var current = this.root;

        while (current != null)
        {
            if (this.Rank(current.Value) >rank)
            {
                current = current.Left;
                 
            }
            if (this.Rank(current.Value) < rank)
            {
                current = current.Right;

            }

            if (this.Rank(current.Value) == rank)
            {
                return current.Value;

            }



        }

        return this.root.Value;

    }

    public T Ceiling(T element)
    {
        if (this.root == null)
        {
            throw new InvalidOperationException("Tree is empty");
        }

        Node current = this.root;

        Node parent = null;


        string direction = "";

        while (current.Value.CompareTo(element) != 0)
        {
            

            if (current.Value.CompareTo(element) < 0)
            {
                parent = current;
                current = current.Right;
                direction = "R";
            }

            if (current.Value.CompareTo(element) > 0)
            {
                parent = current;
                current = current.Left;
                direction = "L";
            }


        }

        if (direction == "L")
            return parent.Value;

        else
        {
            if (current.Right != null)
            {
                return current.Right.Value;
            }
            else
            {
                var start = root;
                parent = null;
                while (start.Value.CompareTo(element)>0)
                {
                    parent = start;
                    start = start.Left;

                }

                return parent.Value;


            }
        }


    }

    public T Floor(T element)
    {
        if (this.root == null)
        {
            throw new InvalidOperationException("Tree is empty");
        }

        Node current = this.root;

        Node parent = null;

        while (current.Value.CompareTo(element)!=0)
        {

            if (current.Value.CompareTo(element) < 0)
            {
                parent = current;
                current = current.Right;

            }

            if (current.Value.CompareTo(element) > 0)
            {
                parent = current;
                current = current.Left;

            }


        }

        if (current.Left != null)
        {
            var rightest = current.Left;

            while (rightest.Right != null)
            {
                rightest = rightest.Right;
            }

            return rightest.Value;
        }
        else
        {
            return parent.Value;
        }

        //if (parent == null)
        //{
        //    this.root = this.root.Right;
        //}
        //else
        //{
        //    parent.Left = current.Right;
        //}
    }

    public class Node
    {
        public Node(T value)
        {
            this.Value = value;
        }

        public T Value { get; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Count { get; set; }
    }
}

public class Launcher
{
    public static void Main(string[] args)
    {
        BinarySearchTree<int> bst = new BinarySearchTree<int>();

        InsertNodesIntoTree(bst);

        bst.EachInOrder(Console.WriteLine);

        //test1(bst);

        //test2(bst);

        //test3(bst);

        //test4(bst);

        //test5(bst);

        bst.Delete(1);

        bst.EachInOrder(Console.WriteLine);

    }

    private static void test5(BinarySearchTree<int> bst)
    {
        int ceiling = bst.Ceiling(4);

        Console.WriteLine(ceiling);
    }

    private static void test4(BinarySearchTree<int> bst)
    {
        int floor = bst.Floor(45);

        Console.WriteLine(floor);
    }

    private static void test3(BinarySearchTree<int> bst)
    {
        int rank = bst.Select(5);

        Console.WriteLine(rank);
    }

    private static void test2(BinarySearchTree<int> bst)
    {
        int rank = bst.Rank(5);

        Console.WriteLine(rank);
    }

    private static void test1(BinarySearchTree<int> bst)
    {
        for (int i = 0; i < 5; i++)
        {
            bst.DeleteMax();

            Console.WriteLine();
            bst.EachInOrder(Console.WriteLine);

        }

        Console.WriteLine();

        Console.WriteLine(bst.Count());
    }

    private static void InsertNodesIntoTree(BinarySearchTree<int> bst)
    {
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(1);
        bst.Insert(4);
        bst.Insert(8);
        bst.Insert(9);
        bst.Insert(37);
        bst.Insert(39);
        bst.Insert(45);
    }
}
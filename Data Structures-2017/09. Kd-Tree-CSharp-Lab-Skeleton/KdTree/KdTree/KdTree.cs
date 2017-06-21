using System;

public class KdTree
{
    private Node root;

    public class Node
    {
        public Node(Point2D point)
        {
            this.Point = point;
        }

        public Point2D Point { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    public Node Root
    {
        get
        {
            return this.root;
        }
    }

    private int Compare(Point2D a, Point2D b, int depth)
    {
        int cmp = 0;

        if (depth % 2 == 0)
        {
            cmp = a.X.CompareTo(b.X);

            if (cmp == 0)
            {
                cmp = a.Y.CompareTo(b.Y);
            }

            return cmp;
        }
        else
        {
            cmp = cmp = a.Y.CompareTo(b.Y);

            if (cmp == 0)
            {
                cmp = a.X.CompareTo(b.X);
            }

        }

        return cmp;

    }
    public bool Contains(Point2D point)
    {
        return Contains(root, point, 0);
    }

    private bool Contains(Node node, Point2D point, int depth)
    {
        if (node == null)
        {
            return false;
        }
        if (this.Compare(node.Point, point, depth) > 0)
        {
           return Contains(node.Left, point, depth + 1);

        }
        else if (this.Compare(node.Point, point, depth) < 0)
        {
           return Contains(node.Right, point, depth + 1);
        }

        else
            return true;
    }

    public void Insert(Point2D point)
    {
        root = this.Insert(this.root, point, 0);
    }

    private Node Insert(Node node, Point2D point, int depth)
    {
        if (node == null)
        {
            return new Node(point);
        }
        if (this.Compare(node.Point, point, depth) > 0)
        {
            node.Left = Insert(node.Left, point, depth + 1);
        }
        else
        {
            node.Right = Insert(node.Right, point, depth + 1);
        }
        return node;
    }

    public void EachInOrder(Action<Point2D> action)
    {
        this.EachInOrder(this.root, action);
    }

    private void EachInOrder(Node node, Action<Point2D> action)
    {
        if (node == null)
        {
            return;
        }

        this.EachInOrder(node.Left, action);
        action(node.Point);
        this.EachInOrder(node.Right, action);
    }
}

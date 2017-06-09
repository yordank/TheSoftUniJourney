using System;
using System.Collections.Generic;

public class AStar
{
    public PriorityQueue<Node> open { get; set; }
    public Dictionary<Node, Node> parents { get; set; }

    public Dictionary<Node, int> cost { get; set; }
    public char[,] map { get; set; }
    public AStar(char[,] map)
    {
        this.map = map;
        this.open = new PriorityQueue<Node>();
        this.parents = new Dictionary<Node, Node>();
        this.cost = new Dictionary<Node, int>();
    }

    public static int GetH(Node current, Node goal)
    {

        var deltaX = Math.Abs(current.Col - goal.Col);

        var deltaY = Math.Abs(current.Row - goal.Row);

        return deltaX + deltaY;
    }

    public IEnumerable<Node> GetPath(Node start, Node goal)
    {

        this.open.Enqueue(start);

        this.parents[start] = null;

        this.cost[start] = 0;

        while (open.Count > 0)
        {
            Node current = open.Dequeue();

            if (current == goal)
                break;

            if (current.Row > 0)
            {
                Node up = new Node(current.Row, current.Col);

                up.Row -= 1;


                int flag = 0;

                int newCost = cost[current] + 1;

                if (!cost.ContainsKey(up) && CheckMap(up))
                {
                    cost.Add(up, newCost);

                    up.F = newCost + GetH(up, goal);

                    open.Enqueue(up);

                    parents[up] = current;

                    flag = 1;

                }

                if (flag == 0 && CheckMap(up))
                    if (newCost < cost[up])
                    {
                        cost[up] = newCost;

                        up.F = newCost + GetH(up, goal);

                        open.DecreaseKey(up);

                        parents[up] = current;


                    }


            }







            if (current.Col < map.GetLength(1) - 1)
            {
                Node up = new Node(current.Row, current.Col);
                up.Col += 1;

                int flag = 0;

                int newCost = cost[current] + 1;

                if (!cost.ContainsKey(up) && CheckMap(up))
                {
                    cost.Add(up, newCost);

                    up.F = newCost + GetH(up, goal);

                    open.Enqueue(up);

                    parents[up] = current;

                    flag = 1;

                }

                if (flag == 0 && CheckMap(up))
                    if (newCost < cost[up])
                    {
                        cost[up] = newCost;

                        up.F = newCost + GetH(up, goal);

                        open.DecreaseKey(up);

                        parents[up] = current;


                    }


            }







            if (current.Col > 0)
            {
                Node up = new Node(current.Row, current.Col);
                up.Col -= 1;

                int flag = 0;

                int newCost = cost[current] + 1;

                if (!cost.ContainsKey(up) && CheckMap(up))
                {
                    cost.Add(up, newCost);

                    up.F = newCost + GetH(up, goal);

                    open.Enqueue(up);

                    parents[up] = current;

                    flag = 1;

                }

                if (flag == 0 && CheckMap(up))
                    if (newCost < cost[up])
                    {
                        cost[up] = newCost;

                        up.F = newCost + GetH(up, goal);

                        open.DecreaseKey(up);

                        parents[up] = current;


                    }


            }



            if (current.Row < map.GetLength(0) - 1)
            {
                Node up = new Node(current.Row, current.Col);
                up.Row += 1;

                int flag = 0;

                int newCost = cost[current] + 1;



                if (!cost.ContainsKey(up) && CheckMap(up))
                {
                    cost.Add(up, newCost);

                    up.F = newCost + GetH(up, goal);

                    open.Enqueue(up);

                    parents[up] = current;

                    flag = 1;

                }

                if (flag == 0 && CheckMap(up))
                    if (newCost < cost[up])
                    {
                        cost[up] = newCost;

                        up.F = newCost + GetH(up, goal);

                        open.DecreaseKey(up);

                        parents[up] = current;


                    }


            }



        }

        List<Node> path = new List<Node>();

        if (!parents.ContainsKey(goal))
        {
            path.Add(start);

            return path;
        }

        FindPath(goal, path);

        return path;



    }

    private void FindPath(Node goal, List<Node> path)
    {
        Node node = parents[goal];


        path.Add(goal);

        while (node != null)
        {
            path.Insert(0, node);

            node = parents[node];
        }
    }

    private bool CheckMap(Node up)
    {
        return map[up.Row, up.Col] != 'W';
    }
}


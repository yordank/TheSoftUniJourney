using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_BasicTreeData
{
    class Program
    {
        static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();

        private static int deepestNodeLevel = int.MinValue;

        private static int deepestNodeValue = int.MinValue;

        private static List<Tree<int>> longestPathNodes = new List<Tree<int>>();
        static void Main()
        {
            ReadTree();

            //Problem1();
            //Problem2();
            //Problem3();
            //Problem4();
            //Problem5();
            //Problem6();
            //Problem7();
            Problem8();

        }

        private static void Problem8()
        {
            int num = int.Parse(Console.ReadLine());

            var root = GetRootNode();

            Console.WriteLine($"Subtrees of sum {num}:");

            AllSubtreesWithGivenSum(root,num);

        }

        private static int AllSubtreesWithGivenSum(Tree<int>currentNode , int num)
        {
            int value = 0;

            if (currentNode.Children.Count() == 0)
            {
                value = currentNode.Value;
                if (value == num)
                {
                    Console.WriteLine(currentNode.Value);
                }

                return currentNode.Value;
                                

            }

            

            foreach (var child in currentNode.Children)
            {
                value += AllSubtreesWithGivenSum(child, num);
            }

            value += currentNode.Value;

            if (value == num)
            {
                PrintSubTree(currentNode);
                Console.WriteLine();
            }
             
            return value;
        }

        private static void PrintSubTree(Tree<int> currentNode)
        {
            Console.Write($"{currentNode.Value} ");

            foreach (var child in currentNode.Children)
            {
                PrintSubTree(child);
            }


        }


        private static void Problem7()
        {
            int num = int.Parse(Console.ReadLine());

            var root = GetRootNode();

            Console.WriteLine($"Paths of sum {num}:");

            AllPathsWithGivenSum(root, 0,num);


        }

        private static void AllPathsWithGivenSum(Tree<int> currentNode, int currentValue, int num)
        {
            int value = currentNode.Value + currentValue;

            if (value == num)
            {
                longestPathNodes.Clear();

                FindPath(currentNode);

                longestPathNodes.Reverse();

                Console.WriteLine($"{string.Join(" ", longestPathNodes.Select(x => x.Value))}");

            }

            else
            {
                foreach (var child in currentNode.Children)
                {
                    AllPathsWithGivenSum(child, value, num);
                }

            }
               

        }

        private static void Problem6()
        {
            var root = GetRootNode();

            DFS(root, 0);

            longestPathNodes.Reverse();

            Console.WriteLine($"Longest path: {string.Join(" ",longestPathNodes.Select(x=>x.Value))}");

        }

        private static void Problem5()
        {
            var root = GetRootNode();

            DFS(root, 0);

            Console.WriteLine($"Deepest node: {deepestNodeValue}");

        }

        private static void FindPath(Tree<int>currentNode)
        {
            longestPathNodes.Add(currentNode);


            if (currentNode.Parent == null)
                return;

            FindPath(currentNode.Parent);



        }
        private static void DFS(Tree<int>currentNode,int level)
        {
            if (level > deepestNodeLevel)
            {
                deepestNodeLevel = level;

                deepestNodeValue = currentNode.Value;

                longestPathNodes.Clear();

                FindPath(currentNode);

            }

            foreach (var child in currentNode.Children)
            {
                DFS(child, level + 1);
            }


        }

        private static void Problem4()
        {
            var nodes = nodeByValue
                .Where(x => x.Value.Parent!=null && x.Value.Children.Count()!=0)
                .Select(x => x.Key)
                .ToList()
                .OrderBy(x => x);

            Console.WriteLine($"Middle nodes: {string.Join(" ", nodes)}");
        }

        private static void Problem3()
        {
            var nodes = nodeByValue.Where(x => x.Value.Children.Count() == 0).Select(x=>x.Key).ToList().OrderBy(x=>x);

            Console.WriteLine($"Leaf nodes: {string.Join(" ",nodes)}");

        }

        private static void Problem2()
        {
            var root = GetRootNode();
            root.Print();
        }

        private static void Problem1()
        {
            Console.WriteLine($"Root node: {GetRootNode().Value}");
        }

        static Tree<int> GetTreeNodeByValue(int value)
        {

            if (!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new Tree<int>(value);
            }

            return nodeByValue[value];


        }

        static void AddEdge(int parent, int child)
        {
            Tree<int> parentNode = GetTreeNodeByValue(parent);
            Tree<int> childNode = GetTreeNodeByValue(child);

            parentNode.Children.Add(childNode);
            childNode.Parent = parentNode;

        }

        static void ReadTree()
        {
            int nodeCount = int.Parse(Console.ReadLine());

            for (int i = 1; i < nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                AddEdge(int.Parse(edge[0]), int.Parse(edge[1]));
            }

        }

        static Tree<int> GetRootNode()
        {

            return nodeByValue.Values.FirstOrDefault(x => x.Parent == null);

        }


    }
}

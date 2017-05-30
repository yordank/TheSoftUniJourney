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

        static void Main()
        {
            ReadTree();

            //Problem1();
            Problem2();
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

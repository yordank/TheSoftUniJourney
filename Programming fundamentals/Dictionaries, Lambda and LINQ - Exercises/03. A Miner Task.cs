using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                int inputResorce = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(input))
                    resources[input] += inputResorce;
                else
                    resources.Add(input, inputResorce);
                input = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}

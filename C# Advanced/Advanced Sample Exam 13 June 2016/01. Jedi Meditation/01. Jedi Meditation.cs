using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Jedi_Meditation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> Masters = new Queue<string>();
            Queue<string> Knights = new Queue<string>();
            Queue<string> Padawans = new Queue<string>();
            Queue<string> ToshkoAndSlav = new Queue<string>();
            Queue<string> Yoda = new Queue<string>();

            int n = int.Parse(Console.ReadLine());

            for(int i=0;i<n; i++)
            {
                string[] items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in items)
                {
                    if (item[0] == 'm')
                        Masters.Enqueue(item);
                    if (item[0] == 'k')
                        Knights.Enqueue(item);
                    if (item[0] == 'p')
                        Padawans.Enqueue(item);
                    if (item[0] == 't' || item[0] == 's')
                        ToshkoAndSlav.Enqueue(item);
                    if (item[0] == 'y')
                        Yoda.Enqueue(item);
                }

            }

            if (Yoda.Count() != 0)
            {
                Console.WriteLine($"{string.Join(" ", Masters)} {string.Join(" ", Knights)} {string.Join(" ", ToshkoAndSlav)} {string.Join(" ", Padawans)}");
            }
            else
            {
                Console.WriteLine($"{string.Join(" ", ToshkoAndSlav)} {string.Join(" ", Masters)} {string.Join(" ", Knights)} {string.Join(" ", Padawans)}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Collect_Resources
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            var resourses = Console.ReadLine().Split().ToList();



            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
                int start = input[0];
                int step = input[1];
                values.Add(calculateCurrentValue(resourses,start,step));
            }

            Console.WriteLine(values.Max());
        }

        private static int calculateCurrentValue(List<string> resourses, int start, int step)
        {

            bool[] array = new bool[resourses.Count];

            for (int i = 0; i < array.Count(); i++)
            {
                array[i] = false;
            }

            int currentIndex = start;

            int flag = 0;

            int count = resourses.Count();

            int value = 0;

            while (flag == 0)
            {

                if (array[currentIndex] == true)
                {
                    flag = 1;
                    continue;
                }


              

                var ValueAndResourse = resourses[currentIndex].Split('_');

                if (ValueAndResourse[0] == "stone" || ValueAndResourse[0] == "gold" || ValueAndResourse[0] == "wood" || ValueAndResourse[0] == "food")
                {
                    array[currentIndex] = true;

                    if (ValueAndResourse.Count() == 1)
                        value += 1;

                    else
                        value += int.Parse(ValueAndResourse[1]);
                }
                currentIndex = (currentIndex + step) % count;

            }

            return value;

        }
    }
}

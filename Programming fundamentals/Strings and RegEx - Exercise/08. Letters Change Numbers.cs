using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' ,'\t'}, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"{TotalSum(input):f2}");

        }
        static decimal TotalSum(string[] input)
        {
            decimal sum = 0;

            foreach (var item in input)
            {
                if (item.Length >= 3 && (item[item.Length - 1] >= 'a' && item[item.Length - 1] <= 'z' || (item[item.Length - 1] >= 'A' && item[item.Length - 1] <= 'Z')) && ((item[0] >= 'a' && item[0] <= 'z') || (item[0] >= 'A' && item[0] <= 'Z')))
                {
                    decimal number = decimal.Parse(item.Substring(1, item.Length - 2));

                    if (item[0] >= 'a' && item[0] <= 'z')
                    {
                        number = number * (item[0] - 'a' + 1);
                    }

                    else if (item[0] >= 'A' && item[0] <= 'Z')
                    {
                        number = number / (item.First() - 'A' + 1);
                    }

                    if (item.Last() >= 'A' && item.Last() <= 'Z')
                    {
                        number = number - (item.Last() - 'A' + 1);
                    }
                    else
                    {
                        number = number + (item.Last() - 'a' + 1);
                    }

                    sum += number;
                }
               

            }

            return sum;
        }


    }
}

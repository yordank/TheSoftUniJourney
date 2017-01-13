using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> array2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int Bomber = array2[0];
            int Power = array2[1];



            int flag = 1;
            int ind = 0;
            while (flag == 1)
            {

                for (int i = ind; i < array.Count; i++)
                {
                    flag = 0;
                    if (array.ElementAt(i) == Bomber)
                    {

                        array.RemoveRange(Math.Max(i - Power, 0), Math.Min(Power, i) + Math.Min(Power + 1, array.Count - i));
                        flag = 1;
                        ind = Math.Max(i - Power - 1, 0);
                        array.Add(0);
                        break;
                    }
                    

                }

            }

            //Console.WriteLine(string.Join(" ",array));
            Console.WriteLine(array.Sum());

        }
    }
}

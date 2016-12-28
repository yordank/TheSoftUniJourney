using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;



namespace _02.Jedi_Galaxy
{

    

    class Program
    {
        static void Main(string[] args)
        {

            var dimenensions = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            bool[,] array=new bool[dimenensions[0],dimenensions[1]];

            for (int i = 0; i < dimenensions[0];i++)
            {
                for (int j = 0; j < dimenensions[1]; j++)
                {
                    array[i, j] = true;
                 }
            }

            BigInteger  sum = 0;
            string input = Console.ReadLine();

            while (input != "Let the Force be with you")
            {


                var IvoPosition = input.Split().Select(x => int.Parse(x)).ToList();
                var EvilPosition = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

                while (EvilPosition[1] >= 0 &&EvilPosition[0]>=0)
                {
                    if (EvilPosition[1] < dimenensions[1] && EvilPosition[0] < dimenensions[0])
                    array[EvilPosition[0], EvilPosition[1]] = false;
                
                    EvilPosition[0]--;
                    EvilPosition[1]--;

                }

                while (IvoPosition[1] < dimenensions[1] && IvoPosition[0] >= 0)
                {
                    if (IvoPosition[1] >= 0 && IvoPosition[0]<dimenensions[0])
                    {
                        if (array[IvoPosition[0], IvoPosition[1]] == true)
                        sum += generateNumber(IvoPosition[0],IvoPosition[1],dimenensions[0],dimenensions[1]);
                    }
                    IvoPosition[0]--;
                    IvoPosition[1]++;

                }

                input = Console.ReadLine();

            }
            Console.WriteLine(sum);


        }

        private static BigInteger generateNumber(BigInteger row, BigInteger col,BigInteger dim1,BigInteger dim2)
        {
            return row * dim2 + col;
        }
    }
}

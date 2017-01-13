using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            //(sbyte < byte < short < ushort < int < uint < long).
            //int num = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int flag = 0;
            try
            {
                var num = new sbyte();
                num = sbyte.Parse(input);

                if (flag == 0)
                    Console.WriteLine($"{num} can fit in:");

                Console.WriteLine("* sbyte");
                flag = 1;

            }
            catch
            {
                
                
                
            }

            try
            {
                var num = new byte();
                num = byte.Parse(input);

                if (flag == 0)
                    Console.WriteLine($"{num} can fit in:");

                Console.WriteLine("* byte");
                flag = 1;
            }
            catch
            {
                 

            }


            try
            {
                var num = new short();
                num = short.Parse(input);

                if (flag == 0)
                    Console.WriteLine($"{num} can fit in:");


                Console.WriteLine("* short");
                flag = 1;
            }
            catch
            {
                

            }

            try
            {
                var num = new ushort();
                num = ushort.Parse(input);

                if (flag == 0)
                    Console.WriteLine($"{num} can fit in:");

                Console.WriteLine("* ushort");
                flag = 1;
            }
            catch
            {


            }

            try
            {
                var num = new int();
                num = int.Parse(input);

                if (flag == 0)
                    Console.WriteLine($"{num} can fit in:");


                Console.WriteLine("* int");
                flag = 1;
            }
            catch
            {


            }

            try
            {
                var num = new uint();
                num = uint.Parse(input);

                if (flag == 0)
                    Console.WriteLine($"{num} can fit in:");


                Console.WriteLine("* uint");
                flag = 1;
            }
            catch
            {


            }

            try
            {
                var num = new long();
                num = long.Parse(input);

                if (flag == 0)
                    Console.WriteLine($"{num} can fit in:");


                Console.WriteLine("* long");
                flag = 1;
            }
            catch
            {


            }

            if (flag == 0)
                Console.WriteLine($"{input} can't fit in any type"); 

        }
    }
}

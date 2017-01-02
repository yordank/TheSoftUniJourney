using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input!="end")
            {
                var inputElems = input.Split();

                if(inputElems[0]== "exchange")
                {
                    if(int.Parse(inputElems[1])<array.Count() && int.Parse(inputElems[1])>=0)
                        array=Exchange(array, int.Parse(inputElems[1]));
                    else
                        Console.WriteLine("Invalid index");

                }

                if(inputElems[0]=="max" || inputElems[0]=="min")
                {
                    int ind = MaxMinIndex(inputElems[0], inputElems[1],array);

                    if(ind!=-1)
                    Console.WriteLine(ind);
                    else
                    Console.WriteLine("No matches");
                }

                if (inputElems[0] == "first" || inputElems[0] == "last")
                {
                   TakeFirstLast(inputElems[0], int.Parse(inputElems[1]), inputElems[2], array);

                   
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ",array)}]");


        }

        private static void TakeFirstLast(string FirstOrLast, int count, string EvenOrOdd, List<int> array)
        {

            if (count > array.Count)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int evenorodd = 0; ;

            if (EvenOrOdd == "even")
                evenorodd = 0;
            if (EvenOrOdd == "odd")
                evenorodd = 1;

           
               
                var selectedElems = array.Where(x => x % 2 == evenorodd).ToList();

            if (FirstOrLast == "last")
                selectedElems.Reverse();

            if (selectedElems.Count() < count)
                Console.WriteLine($"[{string.Join(", ", selectedElems)}]");

            else
            {
                if (FirstOrLast == "last")
                {
                    var lastElems = selectedElems.Take(count).ToList();
                    lastElems.Reverse();
                    Console.WriteLine($"[{string.Join(", ", lastElems)}]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", selectedElems.Take(count).ToList())}]");
                }
            }
            



        }

        private static int MaxMinIndex(string MaxOrMin, string EvenOrOdd,List<int>array)
        {

            int evenorodd = 0; ;

            if (EvenOrOdd == "even")
                evenorodd = 0;
            if (EvenOrOdd == "odd")
                evenorodd = 1;

            array.Reverse();

            if(MaxOrMin=="max")
            {
                    if (array.Where(k => k % 2 == evenorodd).Count() > 0)
                    {
                        int ind = array.Select((x, y) => new { x, y }).Where(elem => elem.x == array.Where(k => k % 2 == evenorodd).Max()).Select(elem => elem.y).First();

                        array.Reverse();
                        return array.Count()-ind-1;
                    }
            }

            if (MaxOrMin == "min")
            {
                if (array.Where(k => k % 2 == evenorodd).Count() > 0)
                {
                    int ind = array.Select((x, y) => new { x, y }).Where(elem => elem.x == array.Where(k => k % 2 == evenorodd).Min()).Select(elem => elem.y).First();

                    array.Reverse();
                    return array.Count() - ind-1;
                }
            }

            array.Reverse();
            return -1;
        }

        private static List<int> Exchange(List<int> array, int index)
        {
            var firstElems = array.Take(index+1).ToList();
            var lastElems = array.Skip(index + 1).Take(array.Count - index-1).ToList();

            var newArray = lastElems;
            newArray.AddRange(firstElems);

            return newArray;
        }


    }
}

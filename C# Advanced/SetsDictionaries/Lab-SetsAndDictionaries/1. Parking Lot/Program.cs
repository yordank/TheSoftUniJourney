using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            SortedSet<string> set = new SortedSet<string>();

            while (input != "END")
            {
                var op = input.Split(new char[] {','})[0];

                var value= input.Split(new char[] { ',' })[1];

                switch (op)
                {
                    case "IN": set.Add(value);break;
                    case "OUT": set.Remove(value);break;

                }


                input = Console.ReadLine();
            }


            foreach (var setElem in set)
            {
                Console.WriteLine(setElem);
            }

            if(set.Count()==0)
                Console.WriteLine("Parking Lot is Empty");

        }
    }
}

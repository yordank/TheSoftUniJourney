using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var firstLine = Console.ReadLine().Split();

        var secondLine = Console.ReadLine().Split();

        var thirdLine = Console.ReadLine().Split();

        Threeuple<Name, string,Town> threeuple1 = new Threeuple<Name, string,Town>(new Name(firstLine[0], firstLine[1]), firstLine[2],new Town(firstLine[3]));

        Threeuple<string, int, Drunk> threeuple2 = new Threeuple<string, int, Drunk>(secondLine[0], int.Parse(secondLine[1]), new Drunk(secondLine[2]));

        Threeuple<string,double, Bank> threeuple3 = new Threeuple<string, double, Bank>(thirdLine[0], double.Parse(thirdLine[1]), new Bank(thirdLine[2]));


        Console.WriteLine(threeuple1.ToString());

        Console.WriteLine(threeuple2.ToString());

        Console.WriteLine(threeuple3.ToString());

    }
}


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

        Turple<Name, string> turple1 = new Turple<Name, string>(new Name(firstLine[0], firstLine[1]), firstLine[2]);

        Turple<string,int> turple2 = new Turple<string,int>(secondLine[0],int.Parse(secondLine[1]));

        Turple<int,double> turple3 = new Turple<int,double>(int.Parse(thirdLine[0]),double.Parse(thirdLine[1]));

        Console.WriteLine(turple1.ToString());

        Console.WriteLine(turple2.ToString());

        Console.WriteLine(turple3.ToString());


    }
}


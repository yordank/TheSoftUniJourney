using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string ferrariName = typeof(Ferrari).Name;

        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;

        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }

        string name = Console.ReadLine();

        ICar car = new Ferrari(name);

        Console.WriteLine(car.ToString());



    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

        decimal l = decimal.Parse(Console.ReadLine());
        decimal w = decimal.Parse(Console.ReadLine());
        decimal h = decimal.Parse(Console.ReadLine());

        Box box = new Box(l, w, h);

        Console.WriteLine($"Surface Area - {box.surfaceArea():f2}");
        Console.WriteLine($"Lateral Surface Area - {box.lateralSurfaceArea():f2}");
        Console.WriteLine($"Volume - {box.volume():f2}");


    }
}
 

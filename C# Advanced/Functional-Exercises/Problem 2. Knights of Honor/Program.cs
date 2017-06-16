using System;
using System.Linq;

namespace Problem_2.Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> actionPrint = Action_Print;

            Console.ReadLine().Split().ToList().ForEach(actionPrint);

        }

        static public void Action_Print(string str)
        {
            Console.WriteLine("Sir "+str);
        }
    }
}

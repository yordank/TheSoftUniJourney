using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Action_Print
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
            Console.WriteLine(str);
        }
    }
}

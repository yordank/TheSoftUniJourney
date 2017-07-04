using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Drawing_tool
{
    public class Rectangle:Shape
    {
        public int row { get; set; }
        public int col { get; set; }


        public override void Draw()
        {
            for (int i = 0; i < row; i++)
            {
                if (i == 0 || i == row - 1)
                {
                    Console.WriteLine("|" + new string('-', col ) + "|");
                }
                else
                    Console.WriteLine("|" + new string(' ', col ) + "|");
            }
        }

    }
}

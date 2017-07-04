using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Drawing_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if(input=="Square")
            {
                Square sq = new Square();
                sq.x = int.Parse(Console.ReadLine());

                CorDraw cd = new CorDraw(sq);
            }
            else
            {
                Rectangle rec = new Rectangle();

                rec.col = int.Parse(Console.ReadLine());

                rec.row = int.Parse(Console.ReadLine());

             

                CorDraw cd = new CorDraw(rec);
            }
        }
    }
}

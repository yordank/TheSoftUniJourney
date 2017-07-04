using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Drawing_tool
{
    public class Square:Shape
    {
        public int x { get; set; }

         public  override void  Draw()
        {
            for (int i = 0; i < x; i++)
            {
                if(i==0 || i==x-1)
                {
                    Console.WriteLine("|"+new string('-',x)+"|");
                }
                else
                    Console.WriteLine("|" + new string(' ', x ) + "|");
            }
        }
    }
}

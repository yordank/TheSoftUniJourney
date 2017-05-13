using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class StartUp
    {
        static void Main(string[] args)
        {



            //Problems.Problem1.solution();
            //Problems.Problem2.solution();
            //Problems.Problem3.solution();

            string[,] arr = new string[,] 
            {
                { "0","0","0" ,"x","0","x"},
                { "0","x","0" ,"x","0","x"},
                { "0","*","x" ,"0","x","0"},
                { "0","x","0" ,"0","0","0"},
                { "0","0","0" ,"x","x","0"},
                { "0","0","0" ,"x","0","x"}

            };

            var p = new Problems.Problem8();

            p.solution(arr);



             

        }

     

     

      
    }
}

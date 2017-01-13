using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] {' '};
            var str1 = Console.ReadLine().Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
            var str2 = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            int i = 0;
            
            foreach (var t in str1)
            {
                if (i< str2.Length)
                    if (t == str2[i])
             count++;
             else
             break;
             i++;
             }
            i = 0;
                        
            int count2 = 0;
          
            foreach (var t in str2.Reverse().ToArray())
            {
                if(str1.Length-1-i>=0)
                if (t == str1[str1.Length-1-i])
                    count2++;
                else
                    break;
                i++;

                
            }
            
            Console.WriteLine(Math.Max(count,count2));
        }
    }
}

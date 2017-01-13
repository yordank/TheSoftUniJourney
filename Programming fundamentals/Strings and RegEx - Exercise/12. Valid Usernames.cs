using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_7.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input=Console.ReadLine().Split(new char[] {' ','\\','/','(',')'},StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            int index = 0;

            string pattern = "^[A-Za-z][A-Za-z0-9_]{2,24}";

            Regex reg = new Regex(pattern);

            

            List<string> ValidUserNames = new List<string>();



            
            foreach (var item in input)
            {
                if (reg.IsMatch(item)&&item.Length<26)
                {
                    ValidUserNames.Add(item);
                }
            }


         

            
            for (int i = 0; i < ValidUserNames.Count - 1; i++)
            {
                if (ValidUserNames[i].Length + ValidUserNames[i + 1].Length > sum)
                {
                    sum = ValidUserNames[i].Length + ValidUserNames[i + 1].Length;
                    index = i;
                }
            }
            
            Console.WriteLine(ValidUserNames[index]);
            Console.WriteLine(ValidUserNames[index+1]);
        }
    }
}

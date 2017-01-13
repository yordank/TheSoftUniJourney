using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.English_Name_оf_The_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = (Console.ReadLine());
            Console.WriteLine(lastDigitName(number));            

        }
        static string lastDigitName(string number)
        {
            int digit = number[number.Length-1]-'0';
            string output = "";
            switch (digit)
            {
                case 0: output= "zero"; break;
                case 1: output = "one"; break;
                case 2: output = "two"; break;
                case 3: output = "three"; break;
                case 4: output = "four"; break;
                case 5: output = "five"; break;
                case 6: output = "six"; break;
                case 7: output = "seven"; break;
                case 8: output = "eight"; break;
                case 9: output = "nine"; break;
                default: output = "zero";break;
            }
            return output;
        }
    }
}

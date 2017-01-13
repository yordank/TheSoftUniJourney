using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = Console.ReadLine().ToCharArray().Reverse().ToList();
            int number2 = int.Parse(Console.ReadLine());

            while (number1.Last() == '0')
            {
                number1.RemoveAt(number1.Count - 1);
            }

            List<int> result = new List<int>();

            int addNumber = 0;

            

            for (int i = 0; i < number1.Count; i++)
            {
                result.Add(((number1[i]-'0') * number2 + addNumber)%10);
                addNumber = ((number1[i] -'0')* number2 + addNumber) / 10;
            }
            if (addNumber > 0)
                result.Add(addNumber);

            result.Reverse();

            if(number2!=0)
            Console.WriteLine(string.Join("",result));
            else
                Console.WriteLine(0);
        }
    }
}

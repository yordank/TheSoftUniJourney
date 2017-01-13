using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstNumber = Console.ReadLine().ToCharArray().Reverse().ToList();
            var SecondNumber=Console.ReadLine().ToCharArray().Reverse().ToList();

            while (FirstNumber.Last() == '0')
            {
                FirstNumber.RemoveAt(FirstNumber.Count-1);
            }

            while (SecondNumber.Last() == '0')
            {
                SecondNumber.RemoveAt(SecondNumber.Count-1);
            }
            
            if (FirstNumber[FirstNumber.Count-1]=='0' ||SecondNumber[SecondNumber.Count-1]=='0')
                throw new Exception();

            int len = Math.Max(FirstNumber.Count(), SecondNumber.Count());

            int secondlen = SecondNumber.Count();
            int firstlen = FirstNumber.Count();

            if (FirstNumber.Count() > SecondNumber.Count())
            {
                for (int i = 0; i < firstlen - secondlen; i++)
                {
                    SecondNumber.Add('0');
                }
            }
            if(secondlen>firstlen)
            {
                for (int i = 0; i < secondlen-firstlen; i++)
                {
                    FirstNumber.Add('0');
                }
            }


            List<int> result = new List<int>();
          

            int addOne = 0;

            for (int i = 0; i < len; i++)
            {
                
                int digit1 = FirstNumber[i] - '0';
                int digit2 = SecondNumber[i] - '0';

                int newDigit = digit1 + digit2+addOne;

                result.Add(newDigit % 10);
                addOne = newDigit / 10;
            }

            if (addOne > 0)
                result.Add(addOne);

            result.Reverse();
            Console.Write(string.Join("",result));

            


        }
    }
}

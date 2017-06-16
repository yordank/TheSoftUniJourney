using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_12.Little_John
{
    class Program
    {
        static void Main(string[] args)
        {
            string input=string.Empty ;

            
 

            for (int i = 0; i < 4; i++)
            {
                input += Console.ReadLine() + Environment.NewLine;
            }

            string arrowMatcher = "(>>>----->>)|(>>----->)|(>----->)";

            Regex rgx = new Regex(arrowMatcher);

            var arrows = rgx.Matches(input);

            int largeArrowsCount = 0;
            int mediumArrowCount = 0;
            int smallAraowsCount=0;

            foreach (Match match in arrows)
            {
                if (!string.IsNullOrEmpty(match.Groups[1].Value))
                {
                    largeArrowsCount++;
                }
                else if (!string.IsNullOrEmpty(match.Groups[2].Value))
                {
                    mediumArrowCount++;
                }
                else
                {
                    smallAraowsCount++;
                }
            }

           

            string num= String.Format("{0}{1}{2}", smallAraowsCount, mediumArrowCount, largeArrowsCount); ;

            var decNum=Convert.ToString(int.Parse(num), 2);
            var rev = decNum.ToCharArray();

            Array.Reverse(rev);

            var n = decNum + string.Join("",rev);

            Console.WriteLine(Convert.ToInt32(n, 2).ToString());

        }

    }
}

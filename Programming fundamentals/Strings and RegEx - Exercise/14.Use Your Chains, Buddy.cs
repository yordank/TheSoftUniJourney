using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern1 = @"[^a-z0-9|'<p>'|'<\/p>']";
            string pattern2 = @"<p>([a-z0-9 ]*)<\/p>";
         
            input = Regex.Replace(input, pattern1, " ");
           
            var match = Regex.Match(input, pattern2);

            string str = string.Empty;

            while (match.Success)
            {
                string text = match.Groups[1].Value;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] >= 'a' && text[i] <= 'z')
                    {
                        str += (char)((int)(text[i] - (int)'a' + 13) % 26 + 'a');
                    }
                    else
                        str += text[i];
                }
                int a = 5;
                match = match.NextMatch();
            }
            str = Regex.Replace(str, @"\s+", " ");
            Console.WriteLine(str.Trim());

        }
    }
}

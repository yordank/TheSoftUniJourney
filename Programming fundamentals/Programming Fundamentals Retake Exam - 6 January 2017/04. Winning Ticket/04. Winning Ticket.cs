using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        private static int f = 0;
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToList();
            int a = 5;
            int i = 0;
            foreach (var ticket in tickets)
            {
                if (ticket.Count()!=20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                    
                }

                else
                {
                    string str= "@$#^";

                    for (int j = 0; j < str.Count(); j++)
                    {
                        checkWinningTicket(ticket,str[j]);

                        if (f == 1)
                            break;
                    }

                    
                      
                }
                if (f == 0)

                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }

                f = 0;
                i++;
            }

        }

        private static void checkWinningTicket(string ticket,char ch)
        {
            string left = ticket.Substring(0, 10);
            string right = ticket.Substring(10);

            var match1 = Regex.Match(left, "\\"+ch.ToString()+"{6,10}");
            
            var match2 = Regex.Match(right, "[$@#^]" +"{6,10}");

          

            if (match1.Success && match2.Success)
            {
                f = 1;
                int count = Math.Min(match1.ToString().Count(), match2.ToString().Count());
                decimal c = ((decimal)match1.ToString().Count() + match2.ToString().Count()) / 2;
                if (count == 10)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {count}{ch}"+" Jackpot!");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {count}{ch}");
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var InputFirstDate = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            DateTime firstdate = new DateTime(InputFirstDate[2],InputFirstDate[1],InputFirstDate[0]);

            var InputSecondDate = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            DateTime seconddate = new DateTime(InputSecondDate[2], InputSecondDate[1], InputSecondDate[0]);

            List<DateTime> listFreeDates = new List<DateTime>();

            

            int count = 0;
            for (DateTime d = firstdate; d <= seconddate; d = d.AddDays(1))
            {
                if (d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek==DayOfWeek.Sunday)
                    count++;

                else
                    if (d.Month == 1 && d.Day == 1)
                    {
                        count++;
                    }
                else
                    if (d.Month == 3 && d.Day == 3)
                {
                    count++;
                }
                else
                    if (d.Month == 5 && d.Day == 1)
                {
                    count++;
                }
                else
                    if (d.Month == 5 && d.Day == 6)
                {
                    count++;
                }
                else
                    if (d.Month == 5 && d.Day == 24)
                {
                    count++;
                }
                else
                    if (d.Month == 9 && d.Day == 6)
                {
                    count++;
                }
                else
                    if (d.Month == 9 && d.Day == 22)
                {
                    count++;
                }
                else
                    if (d.Month == 11 && d.Day == 1)
                {
                    count++;
                }
                else
                    if (d.Month == 12 && (d.Day == 24 || d.Day==25 || d.Day==26) )
                {
                    count++;
                }
            }
            Console.WriteLine((seconddate-firstdate).Days+1-count);

        }
    }
}

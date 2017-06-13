using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.Valid_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"^(\d+):(\d+):(\d+) [A|P]M$");
            while (input != "END")
            {
                Match match = regex.Match(input);
                if (match.Success)
                    if (IsValidTime(match))
                        Console.WriteLine("valid");
                    else
                        Console.WriteLine("invalid");
                else
                    Console.WriteLine("invalid");

                input = Console.ReadLine();
            }

        }

        private static bool IsValidTime(Match clock)
        {
            int hours = int.Parse(clock.Groups[1].Value);
            int minutes = int.Parse(clock.Groups[2].Value);
            int seconds = int.Parse(clock.Groups[3].Value);
            if (hours >= 0 && hours <= 12)
                if (minutes >= 0 && minutes < 60)
                    if (seconds >= 0 && seconds < 60)
                        return true;

            return false;

        }
    }
}

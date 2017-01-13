using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
 

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            BigInteger days = (BigInteger)(years * 365.2422);
            BigInteger hours = days * 24;
            BigInteger minutes = hours * 60;
            BigInteger seconds =(BigInteger) minutes * 60;
            BigInteger millisecond = seconds * 1000;
            BigInteger microsecond = millisecond * 1000;
            BigInteger nanosecond = microsecond * 1000;
            Console.Write($"{centuries} centuries = {years} years");
            Console.Write($" = {days} days = {hours} hours");
            Console.Write($" = {minutes} minutes = {seconds} seconds");
            Console.Write($" = {millisecond} milliseconds = {microsecond} microseconds = {nanosecond} nanoseconds");
        }
    }
}

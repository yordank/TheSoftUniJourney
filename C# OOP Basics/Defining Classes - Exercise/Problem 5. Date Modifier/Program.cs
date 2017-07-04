using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Date_Modifier
{
    public class DateModifier
    {
        public int calcDiffrence(string date1,string date2)
        {

            return (int)Math.Abs((new DateTime(int.Parse(date1.Split()[0]), int.Parse(date1.Split()[1]), int.Parse(date1.Split()[2])) - new DateTime(int.Parse(date2.Split()[0]), int.Parse(date2.Split()[1]), int.Parse(date2.Split()[2]))).TotalDays);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier dm = new DateModifier();

            Console.WriteLine(dm.calcDiffrence(date1,date2));
        }
    }
}

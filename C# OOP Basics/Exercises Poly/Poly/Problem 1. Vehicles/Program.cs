using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            var sb =new  StringBuilder();

            var inputCarItems = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(inputCarItems[1]), double.Parse(inputCarItems[2]));

            var inputTruckItems = Console.ReadLine().Split();

            Vehicle truck = new Truck(double.Parse(inputTruckItems[1]), double.Parse(inputTruckItems[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if(inputTokens[0]=="Drive")
                {
                    if (inputTokens[1] == "Car")
                       sb.AppendLine( car.DriveVehincle(double.Parse(inputTokens[2])));
                }

                if (inputTokens[0] == "Drive")
                {
                    if (inputTokens[1] == "Truck")
                       sb.AppendLine( truck.DriveVehincle(double.Parse(inputTokens[2])));
                }

                if (inputTokens[0] == "Refuel")
                {
                    if (inputTokens[1] == "Car")
                        car.Refueled(double.Parse(inputTokens[2]));
                }
                if (inputTokens[0] == "Refuel")
                {
                    if (inputTokens[1] == "Truck")
                        truck.Refueled(double.Parse(inputTokens[2]));
                }


            }

            sb.AppendLine(car.ToString());
            sb.AppendLine(truck.ToString());
            //Console.WriteLine();
            Console.WriteLine(sb.ToString());
        }
    }
}

using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse);
            List<int> arr = nums.ToList();
            int k = arr.Count/4;
            var arr1= arr.Select((x, y) => new { x, y }).Where(d => d.y < k).Select(s => s.x).Reverse();
            var arr2 = arr.Select((x, y) => new { x, y }).Where(d => d.y <= 4*k && d.y >= 3*k).Select(s => s.x).Reverse();
            var arr3 = arr.Select((x, y) => new { x, y }).Where(d => d.y >= k && d.y < 3 * k).Select(s => s.x);
             
            var arr4 = arr3.Select((x, y) => new { x, y }).Where(d => d.y < k).Select(s => s.x+arr1.ElementAt(s.y)); 
            var arr5 = arr3.Select((x, y) => new { x, y }).Where(d => d.y >= k).Select(s => s.x + arr2.ElementAt(s.y-k));


            Console.Write(string.Join(" ",arr4));
            Console.Write(" ");
            Console.WriteLine(string.Join(" ", arr5));
        }
    }
}

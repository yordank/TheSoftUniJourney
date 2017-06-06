using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = "../../Program.cs";

            using (var reader = new StreamReader(filePath))
            {
                using (var writer = new StreamWriter("../../Lines.txt"))
                {
                    string line = reader.ReadLine();

                    int lineNumber = 1;

                    while (line != null)
                    {
                       
                        writer.Write($"{lineNumber}: {line}");
                      
                        writer.WriteLine();

                        line = reader.ReadLine();

                        lineNumber++;

                    }



                }
            }
        }
    }
}

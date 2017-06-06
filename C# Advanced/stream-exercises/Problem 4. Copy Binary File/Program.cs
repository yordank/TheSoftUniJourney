using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Copy_Binary_File
{
    class Program
    {
        const string ProgrammingImagePath = "../../keep-calm-and-programing.png";

        const string DestinationPath = "../../result.jpg";
        static void Main(string[] args)
        {

            using (var source = new FileStream(ProgrammingImagePath, FileMode.Open))
            {
                using (var destination = new FileStream(DestinationPath, FileMode.Create))
                {
                    double fileLength = source.Length;

                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);

                        Console.WriteLine("{0:P}", Math.Min(source.Position / fileLength, 1));
                    }
                }
            }


        }
    }
}

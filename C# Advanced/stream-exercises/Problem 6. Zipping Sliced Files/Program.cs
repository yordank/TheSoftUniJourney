using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Zipping_Sliced_Files
{
    class Program
    {
        static void Main(string[] args)
        {

            int parts = 3;

            string fileName = "../../keep-calm-and-programing.png";

            string destinationDirectory = "../../";

            Slice(fileName, destinationDirectory, parts);

            Assemble(Directory.GetFiles("../../").Where(x => x.Contains(".gz")).ToList(), "../../");

        }


        private static void Assemble(List<string> fileNames, string destinationDirectory)
        {

            foreach (var file in fileNames)
            {
               // var newFile = new FileStream("", FileMode.Create);
                Decompress(file, file+"decompless");
            }

             
            using (var destination = new FileStream($"{destinationDirectory}result.jpg", FileMode.Create))
            {
                foreach (var file in fileNames)
                {


                    using (var source = new FileStream(file+"decompless", FileMode.Open))
                    {
                        double fileLength = source.Length;

                        byte[] buffer = new byte[source.Length];


                        int readBytes = source.Read(buffer, 0, buffer.Length);


                        destination.Write(buffer, 0, readBytes);


                    }


                }



            }


        }


        private static void Slice(string fileName, string destinationDirectory, int parts)
        {
            using (var source = new FileStream(fileName, FileMode.Open))
            {
                long partSize = source.Length / parts + source.Length % parts;

                for (int i = 0; i < parts; i++)
                {

                    using (var destination = new FileStream($"{destinationDirectory}part{i + 1}", FileMode.Create))
                    {
                        double fileLength = source.Length;

                        byte[] buffer = new byte[4096];

                        int count = 0;

                        while (count < partSize)
                        {
                            int readBytes = source.Read(buffer, 0, buffer.Length);

                            if (readBytes == 0)
                            {
                                break;
                            }

                            destination.Write(buffer, 0, readBytes);

                            count += readBytes;

                        }

                       



                    }

                    Compress($"{destinationDirectory}part{i + 1}", $"{destinationDirectory}part{i + 1}.gz");

                }

            }



        }


        static void Decompress(string inputFile, string outputFile)
        {
            using (var inputStream = new FileStream(inputFile, FileMode.Open))
            {
                using (var compressionStream = new GZipStream(inputStream, CompressionMode.Decompress, false))
                {
                    using (var outputStream = new FileStream(outputFile, FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];
                        while (true)
                        {
                            int readBytes = compressionStream.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            outputStream.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }

        static void Compress(string inputFile, string outputFile)
        {
            using (var inputStream = new FileStream(inputFile, FileMode.Open))
            {
                using (var outputStream = new FileStream(outputFile, FileMode.Create))
                {
                    using (var compressionStream = new GZipStream(outputStream, CompressionMode.Compress, false))
                    {
                        byte[] buffer = new byte[4096];
                        while (true)
                        {
                            int readBytes = inputStream.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            compressionStream.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }



    }
}

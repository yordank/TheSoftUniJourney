using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_3.Word_Count
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();


            ReadWordsFile(dict);

            FillTheDictionary(dict);

            ExportResult(dict);



        }

        private static void FillTheDictionary(Dictionary<string, int> dict)
        {
            using (var reader2 = new StreamReader("text.txt"))
            {
                var line = reader2.ReadLine();

                while (line != null)
                {
                    var words = line.Split(new char[] { ' ', '.', '?', '!', '-', ',' }).Select(x => x.Trim());

                    line = reader2.ReadLine();

                    foreach (var word in words)
                    {
                        if (dict.ContainsKey(word.ToUpper()))
                        {
                            dict[word.ToUpper()]++;
                        }

                    }

                }



            }
        }

        private static void ExportResult(Dictionary<string, int> dict)
        {
            using (var writer = new StreamWriter("results.txt"))
            {

                foreach (var dictElem in dict.OrderByDescending(x => x.Value))
                {
                   writer.WriteLine($"{dictElem.Key} - {dictElem.Value}");
                }

            }


        }


        private static void ReadWordsFile(Dictionary<string, int> dict)
        {
            using (var reader1 = new StreamReader("words.txt"))
            {
                string line = reader1.ReadLine();

                while (line != null)
                {
                    dict.Add(line.ToUpper(), 0);

                    line = reader1.ReadLine();

                   
                }

            }


        }

    }

   


}


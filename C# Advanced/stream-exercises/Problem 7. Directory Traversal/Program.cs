using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryName = "../../";

            List<string> files = new List<string>();

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            files = Directory.GetFiles(directoryName).ToList();

            ReadDataAndFillDictionary(directoryName, files, dict);

            StringBuilder sb = new StringBuilder();

            PrepareTheOutput(directoryName, dict, sb);

            WriteToDesktop(sb);

        }

        private static void WriteToDesktop(StringBuilder sb)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (var writer = new StreamWriter($"{path}/report.txt"))
            {
                writer.WriteLine(sb);
            }
        }

        private static void PrepareTheOutput(string directoryName, Dictionary<string, List<string>> dict, StringBuilder sb)
        {
            foreach (var dictElem in dict.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                sb.Append(dictElem.Key);

                sb.Append(Environment.NewLine);


                foreach (var file in dictElem.Value.OrderBy(x => GetFileSize($"{directoryName}{x}")))
                {


                    sb.Append($"-- {file} - {GetFileSize($"{directoryName}{file}")}");

                    sb.Append(Environment.NewLine);

                }

            }
        }

        private static void ReadDataAndFillDictionary(string directoryName, List<string> files, Dictionary<string, List<string>> dict)
        {
            foreach (var file in files)
            {

                string ext = file.Substring(file.LastIndexOf('.'));


                if (!dict.ContainsKey(ext))
                {
                    var newList = new List<string>();

                    newList.Add(file.Replace(directoryName, ""));

                    dict.Add(ext, newList);
                }
                else
                {
                    dict[ext].Add(file.Replace(directoryName, ""));
                }

            }
        }

        private static string GetFileSize(string fileName)
        {
            FileInfo FileVol = new FileInfo(fileName);
            string fileLength = FileVol.Length.ToString();
            string length = string.Empty;
            if (FileVol.Length >= (1 << 10))
                length = string.Format("{0}Kb", FileVol.Length >> 10);
            return length;
        }
    }
}

 

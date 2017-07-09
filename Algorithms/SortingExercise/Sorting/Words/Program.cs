using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Program
    {
        public static List<char> arr = new List<char>();
    
        public static List<char> result = new List<char>();
        static void Main(string[] args)
        {
            var letters = Console.ReadLine().ToCharArray();

            List<char> lettersList = new List<char>(letters);

            arr = new List<char>(lettersList);

            int count=WordsCount(new List<char>(),lettersList,'#');

            Console.WriteLine(count);

        }

        private static int WordsCount(List<char> res,List<char> lettersList,char ch)
        {

            if (lettersList.Count() == 0)
            {
                //Console.WriteLine(string.Join("",res));
                return 1;
            }
       

            if (lettersList.Count()==1 && lettersList[0] == ch)
            {
                 
                return 0;
            }
            int count = 0;



            HashSet<char> visited = new HashSet<char>();

            foreach (var letter in lettersList)
            {
                char charLetter = letter;

                if (charLetter == ch || visited.Contains(charLetter))
                {
                    
                    continue;
                   
                }

                arr.Remove(charLetter);

                visited.Add(charLetter);

                result.Add(charLetter);

                count += WordsCount(result, arr.ToList(), charLetter);

                result.Remove(charLetter);
        
                arr.Add(charLetter);


            }

            return count;
        }
    }
}

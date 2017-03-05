using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Create_Person_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArgs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);


            Person person=null;

            if (inputArgs.Count()==0)
            {
                person = new Person();
            }
            else if(inputArgs.Count()==1)
            {

                int age;

                bool res= int.TryParse(inputArgs[0],out age);

                if (res == false)
                {
                   person = new Person(inputArgs[0]);
                }
                else
                {
                    person = new Person(age);
                }

                Console.WriteLine(person); 
            }
            else
            {
                person = new Person(inputArgs[0], int.Parse(inputArgs[1]));

                Console.WriteLine(person);
            }



        }
    }
}

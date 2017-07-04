using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Family_Tree
{
    public class Person
    {
        public Person(string firstName,string lastName,string date)
        {

            this.FirstName = firstName;

            this.LastName = lastName;

            this.Date = date;

            this.Parents = new List<Person>();

            this.Children = new List<Person>();

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string Date { get; set; }

        public List<Person> Parents { get; set; }

        public List<Person> Children { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.FirstName} {this.LastName} {this.Date}");

            sb.AppendLine("Parents:");

            foreach (var parent in this.Parents)
            {
                sb.AppendLine($"{parent.FirstName} {parent.LastName} {parent.Date}");

            }

            sb.AppendLine("Children:");

            foreach (var child in this.Children)
            {
                sb.AppendLine($"{child.FirstName} {child.LastName} {child.Date}");

            }

            return sb.ToString();
        }
    }
}

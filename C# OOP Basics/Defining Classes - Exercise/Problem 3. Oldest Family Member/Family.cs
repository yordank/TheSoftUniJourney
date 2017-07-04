using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Oldest_Family_Member
{
    public class Family
    {
        public List<Person> People { get; set; }

        public Family()
        {
            this.People = new List<Person>();
        }
        public void AddMember(Person p)
        {
            this.People.Add(p);

            this.People.Sort((x, y) => -x.age.CompareTo(y.age));

        }

        public Person GetOldestMember()
        {
            return People.First();
        }

    }
}

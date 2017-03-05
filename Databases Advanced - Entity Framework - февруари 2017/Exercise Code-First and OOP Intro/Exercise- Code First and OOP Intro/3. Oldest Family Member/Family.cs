using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Oldest_Family_Member
{
    class Family
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }
        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person getOldestPerson()
        {
            return members.Where(x => x.Age == members.Max(p => p.Age)).FirstOrDefault();
        }


    }
}

﻿

namespace _3.Oldest_Family_Member
{
    class Person
    {
        private string name;
        private int age;

        public Person():this("No name",1)
        {

        }

        public Person(int age):this("No name",age)
        {

        }

        public Person(string name):this(name,1)
        {

        }

        public Person(string name,int age)
        {
            this.Name = name;
            this.age = age;
        }
        public string Name
         {  get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }

        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }



    }
}

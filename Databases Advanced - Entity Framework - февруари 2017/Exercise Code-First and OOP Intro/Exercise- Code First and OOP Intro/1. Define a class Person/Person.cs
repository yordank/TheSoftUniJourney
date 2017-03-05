
namespace _1.Define_a_class_Person
{
    class Person
    {
        private string name;
        private int age;

        public Person()
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

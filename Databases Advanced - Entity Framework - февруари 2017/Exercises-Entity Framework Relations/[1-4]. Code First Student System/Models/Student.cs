

namespace _1.Code_First_Student_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
            this.Homeworks = new HashSet<Homework>();
        }
        public Student(string Name):this()
        {
            this.Name = Name;
            this.PhoneNumber = "112";
            this.BirthDay = DateTime.Today;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public DateTime? RegisteredOn { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Homework> Homeworks { get; set; }
    }
}

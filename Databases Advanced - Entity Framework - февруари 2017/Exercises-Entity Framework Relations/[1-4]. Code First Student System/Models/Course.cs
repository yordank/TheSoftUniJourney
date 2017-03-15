

namespace _1.Code_First_Student_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
            this.Resources = new HashSet<Resource>();
            this.Homeworks = new HashSet<Homework>();
        }
        public Course(string name,string description,DateTime startdate,DateTime enddate,decimal price):this()
        {
            this.Name = name;
            this.Description = description;
            this.StartDate = startdate;
            this.EndDate = enddate;
            this.Price = price;
        }

        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string  Name { get; set; }
     
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        [Range(0d, (double)decimal.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public decimal Price { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
        public virtual ICollection<Homework> Homeworks { get; set; }

    }
}

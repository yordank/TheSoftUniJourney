 
namespace _1.Code_First_Student_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    public class Homework
    {
        public Homework()
        {

        }
        public Homework(string content,ContentType type,DateTime submitiondate)
        {
            this.Content = content;
            this.ContentType = type;
            this.SumitionDate = submitiondate;
        } 
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public ContentType ContentType { get; set; }
        [Required]
        public DateTime SumitionDate { get; set; }
        
        public virtual Student student { get; set; }
        
        public virtual Course course { get; set; }
    }
}

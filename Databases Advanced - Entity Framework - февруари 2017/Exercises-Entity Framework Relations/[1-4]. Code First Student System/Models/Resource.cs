 

namespace _1.Code_First_Student_System.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public enum ResourceType
    {
        video ,
        presentation ,
        document ,
        other
    }

    public class Resource
    {
        public Resource()
        {
            this.licence = new HashSet<Licence>();
        }
        public Resource(string name,ResourceType type,string url):this()
        {
            this.Name = name;
            this.ResourceType = type;
            this.Url = url;

        }
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public ResourceType ResourceType { get; set; }
        [Required]
        public string Url { get; set; }
         
        

        public virtual ICollection<Licence> licence { get; set; }

        public virtual Course course { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Hospital_Database.Models
{
    public class Visitation
    {
        public Visitation(DateTime date,string comments)
        {
            this.date = date;
            this.comments = comments;
        }

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }
        public DateTime date { get; set; }

        [StringLength(100)]
        public string comments { get; set; }
    }
}

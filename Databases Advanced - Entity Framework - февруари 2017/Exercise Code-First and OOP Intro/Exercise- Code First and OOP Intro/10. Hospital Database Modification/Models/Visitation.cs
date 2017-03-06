namespace _10.Hospital_Database_Modification
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Visitation
    {
        public Visitation()
        {
            this.date = new DateTime(2017, 5, 5);
            comments = "bez komentar";
            Patient_Id = null;
        }
        public int Id { get; set; }

        public DateTime date { get; set; }

        [StringLength(100)]
        public string comments { get; set; }

        public int? Patient_Id { get; set; }

        public virtual Patient Patient { get; set; }

        

        public virtual Doctor doctor { get; set; }
    }
}

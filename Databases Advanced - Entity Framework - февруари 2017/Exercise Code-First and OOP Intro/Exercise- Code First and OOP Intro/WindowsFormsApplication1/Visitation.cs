namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Visitation
    {
        public int Id { get; set; }

        public DateTime date { get; set; }

        [StringLength(100)]
        public string comments { get; set; }

        public int? Patient_Id { get; set; }

        public int? doctor_Id { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Patient Patient { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace _7.Gringotts_Database
{
    public class WizardDeposit
    {
        
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(60)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(1000)]
        public string Notes { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Age { get; set; }

        [MaxLength(100)]
        public string MagicWandCreator { get; set; }

        [Range(1, int.MaxValue/2)]
        [DefaultValue(1)]
        public int MagicWandSize { get; set; }
        [MaxLength(20)]
        public string DepositGroup { get; set; }
        public DateTime DepositStartDate { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal DepositInterest { get; set; }
        public double DepositCharge { get; set; }
        public DateTime DepositExpirationDate { get; set; }
        public bool IsDepositExpired { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _8.Create_User
{
    public class User
    {

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        [StringLength(30, ErrorMessage = "Must be between 4 and 30 characters", MinimumLength = 4)]
        [Required]
        public string Username { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&+<>_])[A-Za-z\d$@$!%*?&+<>_]{6,50}")]
        public string Password {get;set;}

        [RegularExpression(@"(\w+[.-_]?)+\w@(\w+\.?)+\w")]
        [EmailAddress()]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}


        [StringLength(1048576)]
        public string ProfilePicture { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime LastTimeLoggedIn { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }
        public bool IsDeleted { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photographers.Models
{
    public class Photographer
    {
        public Photographer()
        {
            this.Albums = new HashSet<Album>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public DateTime RegisterDate { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

    }
}

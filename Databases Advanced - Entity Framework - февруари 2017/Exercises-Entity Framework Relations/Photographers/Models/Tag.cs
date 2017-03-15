using Photographers.Atrributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photographers.Models
{
    public class Tag
    {
        public Tag()
        {
            this.Albums = new HashSet<Album>();
        }
        public int Id { get; set; }

        [Tag]
        public string Label { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}

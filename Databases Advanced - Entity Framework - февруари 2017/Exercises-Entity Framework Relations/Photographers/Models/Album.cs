using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photographers.Models
{
    public class Album
    {
        public Album()
        {
            this.Pictures = new HashSet<Picture>();
            this.Tags = new HashSet<Tag>();
            this.Photographers = new HashSet<Photographer>();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string BackgroundColor { get; set; }
        public bool isPublic { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public virtual ICollection<Photographer> Photographers { get; set; }

        public int OwnerId { get; set; }
    }
}

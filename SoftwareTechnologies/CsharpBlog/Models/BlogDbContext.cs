using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Blog.Models
{
   

    public class BlogDbContext : IdentityDbContext<ApplicationUser>
    {

        public virtual IDbSet<Article> Articles { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Tag> Tags { get; set; }


        public BlogDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static BlogDbContext Create()
        {
            return new BlogDbContext();
        }
    }
}
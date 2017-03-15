

using Photographers.Data;
using Photographers.Models;
using System.Data.Entity.Validation;
using System.Linq;

namespace Photographers
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PhotographerContext();

            Tag tag = new Tag { Label = "#krushii" };

            context.Tags.Add(tag);

            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                tag.Label = TagTransofrmer.Transform(tag.Label);
                context.SaveChanges();
            }


            System.Console.WriteLine(context.Photographers.Count());
        }
    }
}

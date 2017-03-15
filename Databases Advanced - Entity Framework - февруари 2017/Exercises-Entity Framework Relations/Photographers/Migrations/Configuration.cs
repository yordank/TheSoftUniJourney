namespace Photographers.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Photographers.Data.PhotographerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Photographers.Data.PhotographerContext context)
        {
            Photographer teo = new Photographer
            {
                UserName="teo",
                Password="afsadsado",
                Email="teo@softuni.bg",
                BirthDate=DateTime.Now,
                RegisterDate=DateTime.Now.AddDays(-20)
            };

            context.Photographers.AddOrUpdate(p => p.UserName, teo);
            context.SaveChanges();

            Picture demoPicture = new Picture
            {
                Title = "demo",
                Caption = "demo",
                FileSystemPath = "/public/img/picture.jpg"
            };

            context.Pictures.AddOrUpdate(p=>p.Title,demoPicture);

            Album album = new Album
            {
                Name = "Rodopi",
                BackgroundColor = "yellow",
                isPublic = true,
               
            };
            album.Photographers.Add(teo);
            context.Albums.AddOrUpdate(a => a.Name, album);
            

            album.Pictures.Add(demoPicture);
         

            Tag mountinTag = new Tag
            {
                Label = "#mountin"
            };

            context.Tags.AddOrUpdate(t=>t.Label,mountinTag);

            mountinTag.Albums.Add(album);
         
            context.SaveChanges();
        }
    }
}

namespace _1.Code_First_Student_System.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_1.Code_First_Student_System.StudentSystemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(_1.Code_First_Student_System.StudentSystemContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            Student stud1 = new Student("Pesho");
            Student stud2 = new Student("Vankata");
            Student stud3 = new Student("Dancho");
            Student stud4 = new Student("Gosho");
            Student stud5 = new Student("Petko");
            Student stud6 = new Student("Toni");


            Homework hom1 = new Homework("content1", ContentType.Zip, DateTime.Today);
            Homework hom2 = new Homework("content2", ContentType.Zip, DateTime.Today);
            Homework hom3 = new Homework("content3", ContentType.Zip, DateTime.Today);
            Homework hom4 = new Homework("content4", ContentType.Zip, DateTime.Today);

            stud1.Homeworks = new HashSet<Homework>() { hom1, hom2 };
            stud2.Homeworks = new HashSet<Homework>() { hom3, hom4 };

            Resource res1 = new Resource("res1", ResourceType.other, "softuni.bg");
            Resource res2 = new Resource("res2", ResourceType.presentation, "judge");
            Resource res3 = new Resource("res3", ResourceType.video, "forum");
            Resource res4 = new Resource("res4", ResourceType.other, "facebook");
            Resource res5 = new Resource("res5", ResourceType.other, "softuni.bg");
            Resource res6 = new Resource("res6", ResourceType.document, "judge");
            Resource res7 = new Resource("res7", ResourceType.other, "softuni.bg");
            Resource res8 = new Resource("res8", ResourceType.other, "softuni.bg");
            Resource res9 = new Resource("res9", ResourceType.other, "softuni.bg");
            Resource res10 = new Resource("res10", ResourceType.other, "softuni.bg");
            Resource res11 = new Resource("res11", ResourceType.other, "softuni.bg");
            Resource res12 = new Resource("res12", ResourceType.other, "softuni.bg");
            Resource res13 = new Resource("res13", ResourceType.other, "softuni.bg");
            Resource res14 = new Resource("res14", ResourceType.other, "softuni.bg");




            Course course1 = new Course("DB Advanced", "c# DB advanced Entity", new DateTime(2017, 2, 20), new DateTime(2017, 4, 20),260);
            Course course2 = new Course("DB Basic", "c# DB advanced Entity", new DateTime(2017, 1, 15), new DateTime(2017, 2, 19), 255);
            Course course3 = new Course("OOP", "OOP!!!!!!!!!", new DateTime(2017, 5, 1), new DateTime(2017, 9, 1), 270);


            course1.Resources = new HashSet<Resource>() { res1, res2, res3, res4, res5, res6 };
            course2.Resources = new HashSet<Resource>() { res7 };
            course3.Resources = new HashSet<Resource>() { res8, res9, res10, res11, res12, res13, res14 };

            course1.Students = new HashSet<Student>() { stud1, stud2, stud3,stud4,stud5,stud6 };
            course2.Students = new HashSet<Student>() { stud4, stud5,stud2 };
            course3.Students = new HashSet<Student>() { stud6,stud2,stud1 };

             


            context.Students.AddOrUpdate(s => s.Name, stud1, stud2, stud3,stud4,stud5,stud6);
             
            context.Homeworks.AddOrUpdate(h => h.Content, hom1, hom2, hom3, hom4);
             
            context.Resources.AddOrUpdate(r => r.Name, res1, res2, res3, res4, res5, res6, res7);
            
            context.Courses.AddOrUpdate(c => c.Name, course1,course2,course3);

            context.SaveChanges();

        }
    }
}

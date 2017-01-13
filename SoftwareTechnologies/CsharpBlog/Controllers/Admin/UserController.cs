﻿using Blog.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers.Admin
{
    [Authorize(Roles ="Admin")]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            using (var database = new BlogDbContext())
            {
                var users = database.Users.ToList();

                var admins = GetAdminUserNames(users, database);
                ViewBag.Admins = admins;

                return View(users);
            }

        }

        private HashSet<string>GetAdminUserNames(List<ApplicationUser>users,BlogDbContext context)
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var admins = new HashSet<string>();


            foreach(var user in users )
            {
                if (UserManager.IsInRole(user.Id, "Admin"))
                {
                    admins.Add(user.UserName);
                }
            }

            return admins;

        }


        public ActionResult Edit(string id)
        {

            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                var user = database.Users.Where(u => u.Id == id).First();

                if(user==null)
                {
                    return HttpNotFound();
                }

                var viewModel = new EditUserViewModel();
                viewModel.User = user;
                viewModel.Roles = GetUserRoles(user, database);

                return View(viewModel);

            }


        }

        [HttpPost]
        public ActionResult Edit(string id,EditUserViewModel model)
        {
            if(ModelState.IsValid)
            {
                using (var database = new BlogDbContext())
                {
                    var user = database.Users.FirstOrDefault(u => u.Id == id);

                    if(user == null)
                    {
                        return HttpNotFound();
                    }


                    if (!string.IsNullOrEmpty(model.Password))
                    {
                        var hasher = new PasswordHasher();
                        var passwordHash = hasher.HashPassword(model.Password);
                        user.PasswordHash = passwordHash;
                        
                    }

                    user.Email = model.User.Email;
                    user.FullName = model.User.FullName;
                    user.UserName = model.User.Email;
                    this.setUserRoles(model,user, database);

                    database.Entry(user).State = EntityState.Modified;
            
                        database.SaveChanges();
                     
                     
                    return RedirectToAction("List");
                }


            }


            return View(model);


        }

        private void setUserRoles(EditUserViewModel model, ApplicationUser user, BlogDbContext database)
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();

            foreach(var role in model.Roles )
            {
                if(role.IsSelected && !userManager.IsInRole(user.Id,role.Name) )
                {
                    userManager.AddToRole(user.Id, role.Name);

                }
                else if(!role.IsSelected && userManager.IsInRole(user.Id, role.Name))
                {
                    userManager.RemoveFromRole(user.Id, role.Name);
                }

            }


        }

        private IList<Role> GetUserRoles(ApplicationUser user, BlogDbContext database)
        {
            var userManager = Request.GetOwinContext().GetUserManager < ApplicationUserManager>();


            var roles = database.Roles.Select(r => r.Name).OrderBy(r => r).ToList();


            var userRoles = new List<Role>();

            foreach(var roleName in roles)
            {
                var role = new Role() { Name = roleName };

                if(userManager.IsInRole(user.Id,roleName))
                {
                    role.IsSelected = true;
                }

                userRoles.Add(role);

            }


            return userRoles;

        }


        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                var user = database.Users.Where(x => x.Id.Equals(id)).First();

                if (user == null)
                {
                    return HttpNotFound();
                }

                return View(user);
            }

        }


        //Http Post Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteProcess(string id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                var user = database.Users.Where(x => x.Id.Equals(id)).First();
             

                if (user == null)
                {
                    return HttpNotFound();
                }

                var userArticles = database.Articles.Where(a => a.AuthorId == user.Id);


                foreach (var article in userArticles)
                {
                    database.Articles.Remove(article);
                }

                database.Users.Remove(user);
                database.SaveChanges();

                return RedirectToAction("List");
            }


        }


    }
}
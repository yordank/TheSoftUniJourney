﻿using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        //Get: Article
        public ActionResult List()
        {
            using (var database =new BlogDbContext())
            {
                var articles = database.Articles.Include(a => a.Author).Include(a=>a.Tags).ToList();
                return View(articles);
            }
          
        }

        [Authorize]
        public ActionResult Create()
        {
            using (var database = new BlogDbContext())
            {
                var model = new ArticleViewModel();
                model.categories = database.Categories.OrderBy(x => x.Name).ToList();
                return View(model);
            }

                
        }

        [HttpPost]
        [Authorize]
        public ActionResult Create(ArticleViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var database = new BlogDbContext())
                {

                    var authorId = database.Users.Where(u => u.UserName == this.User.Identity.Name).First().Id;

                    var article = new Article(authorId, model.Title, model.Content, model.CategoryId);

                    this.SetArticleTags(article, model, database);

                    database.Articles.Add(article);

                    database.SaveChanges();

                    return RedirectToAction("Index");
                }
               
            }

            return View(model);

        }

        private void SetArticleTags(Article article, ArticleViewModel model, BlogDbContext database)
        {
            var tagsString = model.Tags.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(t => t.ToLower()).Distinct();

            article.Tags.Clear();

            foreach (var tagString in tagsString)
            {
                Tag tag = database.Tags.FirstOrDefault(x => x.Name.Equals(tagString));

                if(tag==null)
                {
                    tag = new Tag() { Name = tagString };
                    database.Tags.Add(tag);

                }

                article.Tags.Add(tag);
            }
        }

        //Get Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                var article = database.Articles.Where(x => x.Id == id).Include(a => a.Author).Include(a=>a.Tags).First();

                if (article == null)
                {
                    return HttpNotFound();
                }
                return View(article);

            }

        }
        //Get Delete
        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using(var database=new BlogDbContext())
            {
                 var article = database.Articles.Where(a => a.Id == id).Include(a => a.Author).Include(a=>a.Category).First();
                //var article = database.Articles.FirstOrDefault(a => a.Id == id);

                if (!isUserAuthorizedToEdit(article))
                {
                    return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
                }

                ViewBag.TagsString = string.Join(", ", article.Tags.Select(t => t.Name));

                if (article == null)
                {
                    return HttpNotFound();
                }
               /* var model = new ArticleViewModel();

                model.Title = article.Title;
                model.Content = article.Content;
                model.CategoryId = article.CategoryId;
                model.categories = database.Categories.ToList();

                string str= database.Categories.Where(x => x.Id == model.CategoryId).First().Name;
                ViewBag.categoryName = str;
                */
                return View(article);

            }

        }
      
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            using (var database=new BlogDbContext())
            {
                var article = database.Articles.Where(x => x.Id == id).Include(a => a.Author).First();
                if (article == null)
                {
                    return HttpNotFound();
                }
                database.Articles.Remove(article);
                database.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        //Get Edit
        public ActionResult Edit(int? id)
        {

            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                var article = database.Articles.Where(x => x.Id == id).First();
                if (article == null)
                    return HttpNotFound();

                if (!isUserAuthorizedToEdit(article))
                {
                    return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
                }

                var model = new ArticleViewModel();
                model.Id = article.Id;
                model.Title = article.Title;
                model.AuthorId = article.AuthorId;
                model.Content = article.Content;
                model.CategoryId = article.CategoryId;
                model.categories = database.Categories.OrderBy(x => x.Name).ToList();

                model.Tags = string.Join(", ", article.Tags.Select(t => t.Name));

                return View(model);

            }
            
        }

        [HttpPost]
        public ActionResult Edit(ArticleViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var database=new BlogDbContext())
                {
                    var article = database.Articles.FirstOrDefault(a => a.Id == model.Id);

                    article.Title = model.Title;
                    article.Content = model.Content;
                    article.CategoryId = model.CategoryId;
                    this.SetArticleTags(article, model, database);
                    database.Entry(article).State = EntityState.Modified;
                    database.SaveChanges();

                    return RedirectToAction("Index");

                }
            }

            return View(model);

        }

        private bool isUserAuthorizedToEdit(Article article)
        {
            bool isAdmin = this.User.IsInRole("Admin");
            bool isAuthor = article.isAuthor(this.User.Identity.Name);

            return isAdmin || isAuthor;

        }


    }
}
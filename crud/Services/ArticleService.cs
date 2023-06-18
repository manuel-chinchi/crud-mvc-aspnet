using crud.Models;
using crud.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crud.Services
{
    public class ArticleService : IArticleService
    {
        public void CreateArticle(Article article)
        {
            using (var db = new ApplicationContext())
            {
                db.Articles.Add(new Article()
                {
                    Name = article.Name,
                    Description = article.Description,
                    Quantity = article.Quantity,
                    DateCreated = article.DateCreated
                });
                db.SaveChanges();
            }
        }

        public void DeleteArticle(int id)
        {

            using (var db = new ApplicationContext())
            {
                Article article = db.Articles.Where(a => a.Id == id).FirstOrDefault();
                db.Articles.Remove(article);
                db.SaveChanges();
            }
        }

        public Article GetArticle(int id)
        {
            using (var db = new ApplicationContext())
            {
                return db.Articles.Where(a => a.Id == id).FirstOrDefault();
            }
        }

        public List<Article> GetArticles()
        {
            using (var db = new ApplicationContext())
            {
                return db.Articles.ToList();
            }
        }

        public void UpdateArticle(Article article)
        {
            using (var db = new ApplicationContext())
            {
                Article result = db.Articles.FirstOrDefault(a => a.Id == article.Id);

                result.Name = article.Name;
                result.Description = article.Description;
                result.Quantity = article.Quantity;
                result.DateUpdated = DateTime.Now;

                db.SaveChanges();
            }
        }
    }
}
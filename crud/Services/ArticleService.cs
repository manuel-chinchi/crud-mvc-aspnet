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
            throw new NotImplementedException();
        }

        public void DeleteArticle(int id)
        {
            throw new NotImplementedException();
        }

        public Article GetArticle(int id)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetArticles()
        {
            var articles = new List<Article>();
            articles.Add(new Article() { Id = 1, Name = "zapatilla", Description = "nike, talle 43", Quantity = 100 });
            articles.Add(new Article() { Id = 2, Name = "remera", Description = "talle M", Quantity = 50 });
            articles.Add(new Article() { Id = 3, Name = "sombrero", Description = "chino", Quantity = 100 });

            return articles;
        }

        public void UpdateArticle(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
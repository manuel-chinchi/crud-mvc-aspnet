using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services.Contracts
{
    public interface IArticleService
    {
        List<Article> GetArticles();

        Article GetArticle(int id);

        void CreateArticle(Article article);

        void UpdateArticle(Article article);

        void DeleteArticle(int id);
    }
}

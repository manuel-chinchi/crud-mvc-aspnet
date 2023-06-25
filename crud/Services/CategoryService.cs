using crud.Models;
using crud.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services
{
    public class CategoryService : ICategoryService
    {
        public void CreateCategory(Category category)
        {
            using (var db = new ApplicationContext())
            {
                db.Categories.Add(new Category()
                {
                    Name = category.Name,
                    DateCreated = DateTime.Now
                });
                db.SaveChanges();
            }
        }

        public void DeleteCategory(int id)
        {
            using (var db = new ApplicationContext())
            {
                Category category = db.Categories.Where(c => c.Id == id).FirstOrDefault();
                db.Categories.Remove(category);
                db.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            using (var db = new ApplicationContext())
            {
                return db.Categories.Include("Articles").ToList();
            }
        }

        public Category GetCategory(int id)
        {
            using (var db = new ApplicationContext())
            {
                return db.Categories.Where(c => c.Id == id).FirstOrDefault();
            }
        }
    }
}

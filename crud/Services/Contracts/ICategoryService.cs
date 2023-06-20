using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services.Contracts
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        
        Category GetCategory(int id);

        void CreateCategory(Category category);

        void DeleteCategory(int id);
    }
}

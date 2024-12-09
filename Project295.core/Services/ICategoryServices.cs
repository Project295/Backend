using Project295.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Core.Services
{
    public interface ICategoryServices
    {
         List<Category> GetAllCategory();
         Category GetCategoryById(int id);
         void CreateCategory(Category category);
         void UpdateCategory(Category category);
         void DeleteCategory(int id);
    }
}

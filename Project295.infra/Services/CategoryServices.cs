using Project295.API.Models;
using Project295.Core.Repository;
using Project295.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly ICategoryRepository _ctegoryRepository;
        public CategoryServices(ICategoryRepository ctegoryRepository)
        {
            _ctegoryRepository = ctegoryRepository;
        }
        public List<Category> GetAllCategory()
        {
            return null;

        }

        public Category GetCategoryById(int id)
        {
            return null;

        }
        public void CreateCategory(Category category)
        {

        }
        public void UpdateCategory(Category category)
        {

        }

        public void DeleteCategory(int id)
        {

        }
    }
}

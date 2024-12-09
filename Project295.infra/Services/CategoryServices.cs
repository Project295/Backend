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
        public Task<List<Category>> GetAllCategory()
        {
            return _ctegoryRepository.GetAllCategory();
        }

        public Task<Category> GetCategoryById(int id)
        {
            return _ctegoryRepository.GetCategoryById(id);
        }
        public Task CreateCategory(Category category)
        {
            return _ctegoryRepository.CreateCategory(category);
        }
        public Task UpdateCategory(Category category)
        {
            return _ctegoryRepository.UpdateCategory(category);
        }

        public Task DeleteCategory(int id)
        {
            return _ctegoryRepository.DeleteCategory(id);
        }
    }
}

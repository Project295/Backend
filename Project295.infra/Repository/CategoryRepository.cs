using Project295.API.Models;
using Project295.Core.Common;
using Project295.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project295.Infra.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IDbContext _dbContext;

        public CategoryRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
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

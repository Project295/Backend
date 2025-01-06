using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Common;
using Project295.API.Models;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        public CategoryController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Category> GetAllCategory()
        {
            return _dbContext.Categories.ToList();
        }
        [HttpGet]
        [Route("GetCategoryById")]
        public Category GetCategoryById(int id)
        {
            return _dbContext.Categories.FirstOrDefault(x=>x.CategoryId==id);
        }
        [HttpPost]
        [Route("CreateCategory")]
        public void CreateCategory(Category category)
        {
             _dbContext.Categories.Add(category);
        }
        [HttpPut]
        [Route("UpdateCategory")]
        public void UpdateCategory(Category category)
        {
            _dbContext.Categories.Update(category);
        }
        [HttpDelete]
        [Route("DeleteCategory")]
        public void DeleteCategory(int id)
        {
               var category = _dbContext.Categories.FirstOrDefault(x => x.CategoryId == id);
                 _dbContext.Categories.Remove(category);
        }
    }
}

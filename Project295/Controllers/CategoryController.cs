using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project295.API.Models;
using Project295.Core.Services;

namespace Project295.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _categoryServices;
        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        [HttpGet]
        public Task<List<Category>> GetAllCategory()
        {
            return _categoryServices.GetAllCategory();
        }
        [HttpGet]
        [Route("GetCategoryById")]
        public Task<Category> GetCategoryById(int id)
        {
            return _categoryServices.GetCategoryById(id);
        }
        [HttpPost]
        [Route("CreateCategory")]
        public Task CreateCategory(Category category)
        {
            return _categoryServices.CreateCategory(category);
        }
        [HttpPut]
        [Route("UpdateCategory")]
        public Task UpdateCategory(Category category)
        {
            return _categoryServices.UpdateCategory(category);
        }
        [HttpDelete]
        [Route("DeleteCategory")]
        public Task DeleteCategory(int id)
        {
            return _categoryServices.DeleteCategory(id);
        }
    }
}

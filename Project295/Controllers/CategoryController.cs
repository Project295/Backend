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
        public List<Category> GetAllCategory()
        {
            return null;

        }
        [HttpGet]
        [Route("GetCategoryById")]
        public Category GetCategoryById(int id)
        {
            return null;

        }
        [HttpPost]
        [Route("CreateCategory")]
        public void CreateCategory(Category category)
        {

        }
        [HttpPut]
        [Route("UpdateCategory")]
        public void UpdateCategory(Category category)
        {

        }
        [HttpDelete]
        [Route("DeleteCategory")]
        public void DeleteCategory(int id)
        {

        }
    }
}

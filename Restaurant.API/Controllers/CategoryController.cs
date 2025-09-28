using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Core.Data;
using Restaurant.Core.Repositories;
using Restaurant.Core.Services;

namespace Restaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory_Service _category_service;

        public CategoryController(ICategory_Service category_service)
        {
            _category_service = category_service;
        }

        [HttpGet]
        public List<Category> GetAllCategories() //https://localhost:7031/api/category
        {
            return _category_service.GetAllCategories();
        }

        [HttpPost]
        public void CreateCategory(Category category) // https://localhost:7031/api/category
        {
            _category_service.CreateCategory(category);
        }

        [HttpPut]
        public void UpdateCategory(Category category)
        {
            _category_service.UpdateCategory(category);
        }

        [HttpDelete("{id}")]
        public void DeleteCategory(int id)
        {
            _category_service.DeleteCategory(id);
        }

        [HttpGet]
        [Route("GetCategoryById/{id}")]
        public Category GetCategoryById(int id) //https://localhost:7031/api/category/GetCategoryById/2
        {
            return _category_service.GetCategoryByID(id);
        }
    }
}

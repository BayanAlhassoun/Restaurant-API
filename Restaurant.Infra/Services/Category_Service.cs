using Restaurant.Core.Data;
using Restaurant.Core.DTO;
using Restaurant.Core.Repositories;
using Restaurant.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infra.Services
{
    public class Category_Service : ICategory_Service
    {
        private readonly ICategory_Repository _category_Repository; // = new Category_Repository()

        public Category_Service(ICategory_Repository category_Repository) // = new Category_Repository()
        {
            _category_Repository = category_Repository;
        }

        public void CreateCategory(Category category)
        {
            _category_Repository.CreateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            _category_Repository.DeleteCategory(id);
        }

        public List<Category> GetAllCategories()
        {
            return _category_Repository.GetAllCategories();
        }

        public List<Category_Product> GetAllProductsByCategory(string categoryName)
        {
            return _category_Repository.GetAllProductsByCategory(categoryName);
        }

        public Category GetCategoryByID(int id)
        {
            return _category_Repository.GetCategoryByID(id);
        }

        public void UpdateCategory(Category category)
        {
            _category_Repository.UpdateCategory(category);
        }
    }
}

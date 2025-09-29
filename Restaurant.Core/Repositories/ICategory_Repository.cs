using Restaurant.Core.Data;
using Restaurant.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Repositories
{
    public interface ICategory_Repository
    {
       List<Category> GetAllCategories();
       Category GetCategoryByID(int id);
       void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
       List<Category_Product> GetAllProductsByCategory(string categoryName);
    }
}

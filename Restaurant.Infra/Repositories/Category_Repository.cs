using Dapper;
using Restaurant.Core.Common;
using Restaurant.Core.Data;
using Restaurant.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infra.Repositories
{
    public class Category_Repository : ICategory_Repository
    {
        private readonly IDBContext _dBContext; // _dbContext = new DBContext();
        

        public Category_Repository(IDBContext dBContext) // dbContext = new DBContext();
        {
            _dBContext = dBContext;
        }

        public void CreateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("Ct_name", category.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Execute("Categories_Package.CreateCategories", p, commandType: CommandType.StoredProcedure); 
        }

        public void DeleteCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("Ct_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Execute("Categories_Package.DeleteCategories", p, commandType: CommandType.StoredProcedure);
        }

        public List<Category> GetAllCategories()
        {
            var result = _dBContext.Conection.Query<Category>("Categories_Package.GetAllCategories", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Category GetCategoryByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Query<Category>("Categories_Package.GetCategoriesById", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public void UpdateCategory(Category category)
        {
            var p = new DynamicParameters();
            p.Add("Ct_id", category.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Ct_name", category.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dBContext.Conection.Execute("Categories_Package.UpdateCategories", p, commandType: CommandType.StoredProcedure);
        }
    }
}

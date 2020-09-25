using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simple_crud_microsservice.DBContexts;
using simple_crud_microsservice.Models;

namespace simple_crud_microsservice.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductContext _dbContext;

        public CategoryRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _dbContext.categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _dbContext.categories.Find(categoryId);
        }
    }
}

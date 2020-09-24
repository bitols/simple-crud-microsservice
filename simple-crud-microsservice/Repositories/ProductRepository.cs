using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using simple_crud_microsservice.DBContexts;
using simple_crud_microsservice.Models;

namespace simple_crud_microsservice.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;
        
        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteProduct(int productId)
        {
            var product = _dbContext.products.Find(productId);
            _dbContext.products.Remove(product);
            Save();
        }

        public Product GetProductById(int productId)
        {
            return _dbContext.products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }
    }
}

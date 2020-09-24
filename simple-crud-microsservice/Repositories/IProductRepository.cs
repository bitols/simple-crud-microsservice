﻿using simple_crud_microsservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud_microsservice.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productId);
        void InsertProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
        void Save();
    }
}

using Microsoft.EntityFrameworkCore;
using simple_crud_microsservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simple_crud_microsservice.DBContexts
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    id = 1,
                    name = "Electronics",
                    description = "Electronic Items",
                },
                new Category
                {
                    id = 2,
                    name = "Clothes",
                    description = "Dresses",
                },
                new Category
                {
                    id = 3,
                    name = "Grocery",
                    description = "Grocery Items",
                }
            );
        }

    }
}

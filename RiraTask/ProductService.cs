using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RiraTask.Product;

namespace RiraTask
{
    public class ProductService : IProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Category = Categories.Category1, Price = 100 },
            new Product { Id = 2, Name = "Product B", Category = Categories.Category1, Price = 150 },
            new Product { Id = 3, Name = "Product C", Category = Categories.Category2, Price = 120 },
            new Product { Id = 4, Name = "Product D", Category = Categories.Category3, Price = 200 },
            new Product { Id = 5, Name = "Product E", Category = Categories.Category1, Price = 80 }
        };
        }

        public IEnumerable<Product> GetProductsByCategory(Categories category)
        {
            return products.Where(p => p.Category == category);
        }

        public Product GetProductWithHighestPrice()
        {
            return products.OrderByDescending(p => p.Price).FirstOrDefault();
        }

        public decimal CalculateTotalPrice()
        {
            return products.Sum(p => p.Price);
        }

        public IEnumerable<Product> GroupProductsByCategory()
        {
            return products.GroupBy(p => p.Category).SelectMany(g => g);
        }

        public decimal CalculateAveragePrice()
        {
            return products.Average(p => p.Price);
        }
    }
}



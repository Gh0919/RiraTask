using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiraTask
{
    public enum Categories
    {
        Category1,
        Category2,
        Category3
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Categories Category { get; set; }
        public decimal Price { get; set; }

        
        public interface IProductService
        {
            IEnumerable<Product> GetProductsByCategory(Categories category);
            Product GetProductWithHighestPrice();
            decimal CalculateTotalPrice();
            IEnumerable<Product> GroupProductsByCategory();
            decimal CalculateAveragePrice();
        }
    }
}

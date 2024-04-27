using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RiraTask.Product;

namespace RiraTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductService();

            var category1Products = productService.GetProductsByCategory(Categories.Category1);
            Console.WriteLine("Products from Category1:");
            foreach (var product in category1Products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }

            var highestPricedProduct = productService.GetProductWithHighestPrice();
            Console.WriteLine($"Highest Priced Product: {highestPricedProduct.Name} - {highestPricedProduct.Price}");

            var totalPrice = productService.CalculateTotalPrice();
            Console.WriteLine(totalPrice);

            var groupedProducts = productService.GroupProductsByCategory();
            Console.WriteLine("\nGrouped Products:");
            foreach (var group in groupedProducts)
            {
                Console.WriteLine($"Category: {group.Category}, Name: {group.Name}, Price: {group.Price}");
            }

            var averagePrice = productService.CalculateAveragePrice();
            Console.WriteLine(averagePrice);

            Console.ReadKey();
        }
    }
}

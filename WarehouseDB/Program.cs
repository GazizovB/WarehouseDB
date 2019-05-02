using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ProductContext())
            {
                var productName = Console.ReadLine();
                int amount = int.Parse(Console.ReadLine());

                var product = new Product
                {
                    _Product = productName,
                    _Amount = amount
                };
         
                context.Products.Add(product);
                context.SaveChanges();

                var products = context.Products.ToList();

                int count = 1;

                foreach (var item in products)
                {

                    Console.WriteLine(count++ + " " + item._Product+ " " +item._Amount);
                }
                Console.ReadLine();

            }
        }
    }
}

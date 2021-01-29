using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. yol
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //2.yol
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, 
                ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase   //camelCase
            ProductManeger productManeger = new ProductManeger();
            productManeger.Add(product1);

        }
    }
}

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = new ProductManager(new InMemoryProductDal()); 
            ProductManager productManager = new ProductManager(new EfProductDal());

            //ShowAll(productManager);

            //ShowByCategory(productManager);

            ShowByUnitPrice(productManager);
        }

        private static void ShowByCategory(ProductManager productManager)
        {
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void ShowAll(ProductManager productManager)
        {
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);

            }
        }

        private static void ShowByUnitPrice(ProductManager productManager)
        {
            foreach (var product in productManager.GetByUnitPrice(10, 130))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}

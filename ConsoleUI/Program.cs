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
            //ProductManager productManager = new ProductManager(new EfProductDal());

            //ShowAll(productManager);

            //ShowByCategory(productManager);

            //ShowByUnitPrice(productManager);

            //ShowAllCategories();

            JoinTest();
        }

        private static void JoinTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductId + ", " +
                                    product.ProductName + ", " +
                                    product.CategoryName + ", " +
                                    product.UnitsInStock + "\n");
            }
        }

        private static void ShowAllCategories()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
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

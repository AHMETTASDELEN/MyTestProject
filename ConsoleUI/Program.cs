using Business.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //ProductManager productManager = new ProductManager(new EfProductDal());
            //var result = productManager.GetAll();
            //Console.WriteLine(result.Message);
            //if (result.Success=false)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}





            //ProductManager productManager = new ProductManager
            //    (new EfProductDal(),
            //    new CategoryManager(new EfCategoryDal()));

            //ProductManager productManager = new ProductManager(new EfProductDal());

            //var result = productManager.GetAll();
            //if (result.Success == true)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //var result = productManager.GetProductDetails();
            //if (result.Success == true)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            //        Console.WriteLine(result.Message);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
        }


        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(1, 50))
            {
                Console.WriteLine(product.ProductName /*+ "/" + product.CategoryName*/);
                global::System.Console.WriteLine(result.Message);
            }
        }
    }
}

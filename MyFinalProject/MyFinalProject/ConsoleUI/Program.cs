using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManger productManger = new ProductManger(new EfProductDal());

            foreach (var product in productManger.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--Kategoriye göre seçim--");

            foreach (var product in productManger.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--Ücrete göre seçim--");
            foreach (var product in productManger.GetByUnitPrice(20,21))
            {
                Console.WriteLine(product.ProductName);
            }
          
            
            

        }

       
    }
}

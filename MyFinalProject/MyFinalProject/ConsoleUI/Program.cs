using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManger productManger = new ProductManger(new InMemoryProductDal());

            foreach (var product in productManger.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

          
            
            

        }

       
    }
}

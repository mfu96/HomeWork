using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> Categories = new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Bilgisayar"},
                new Category {CategoryId = 2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "16 GB RAM",
                    UnitPrice = 10000, UnitInStock = 5
                },
                new Product
                {
                    ProductId = 2, CategoryId = 1, ProductName = "Dell Laptop", QuantityPerUnit = "32 GB RAM",
                    UnitPrice = 8000, UnitInStock = 3
                },
                new Product
                {
                    ProductId = 3, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "8 GB RAM",
                    UnitPrice = 6000, UnitInStock = 2
                },
                new Product
                {
                    ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB RAM",
                    UnitPrice = 5000, UnitInStock = 15
                },
                new Product
                {
                    ProductId = 5, CategoryId = 1, ProductName = "Apple Telfon", QuantityPerUnit = "3 GB RAM",
                    UnitPrice = 8000, UnitInStock = 0
                },

            };
            Console.WriteLine("-----Algoritmik-------");
            //Algoritmik, daha uzun karmaşık ve zor
            foreach (var pro in products)
            {
                if (pro.UnitPrice > 5000 && pro.UnitInStock > 3)
                {
                    Console.WriteLine(pro.ProductName);
                }
            }

            Console.WriteLine("----Linq---------");
            //İlk etapta daha fazla veya zor gibi gelse de sorguya ekleme yapmaya başladıkça Linq kurtarıcı durumuna geçiyor

            var result = products.Where(pro => pro.UnitPrice > 5000 && pro.UnitInStock > 3);
            foreach (var pro in result)
            {
                Console.WriteLine("{0} Stok kodu: {1}", pro.ProductName, pro.UnitInStock);

            }

            //Linq kullanmadığımızada bir filtre methodu
            static List<Product> GetProducts(List<Product> products)
            {
                List<Product> filteredPro = new List<Product>();

                foreach (var proInstance in products)
                {
                    if (proInstance.UnitPrice > 5000 && proInstance.UnitInStock > 2)
                    {
                        filteredPro.Add(proInstance);
                    }

                }

                return filteredPro;
            }

            //Linq ile kullanım
            static List<Product> GetProductsLinq(List<Product> products)
            {
                return products.Where(proInstence => proInstence.UnitPrice >
                    4000 && proInstence.UnitInStock > 2).ToList();
            }




        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

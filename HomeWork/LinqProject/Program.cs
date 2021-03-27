using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
                    UnitPrice = 8000, UnitInStock = 2
                },
                new Product
                {
                    ProductId = 4, CategoryId = 2, ProductName = "Samsung Telefon", QuantityPerUnit = "4 GB RAM",
                    UnitPrice = 5000, UnitInStock = 15
                },
                new Product
                {
                    ProductId = 5, CategoryId = 1, ProductName = "Apple Telefon", QuantityPerUnit = "3 GB RAM",
                    UnitPrice = 8000, UnitInStock = 0
                },

            };
            NotLinq(products);

            WithLinq(products);

            NotLinqExample();

            WithLinqExample();

            AnyLinq(products);

            FindLinq(products);

            FindAllLinq(products);

            WhereForOrderBy(products);

            AscDesc(products);

            ClassicLinq(products);

            Console.WriteLine("--JoinLinq--");
           var result8 = from p in products
                          join c in Categories
                          on p.CategoryId equals c.CategoryId
                          select new ProductDto
                          {
                              ProductId = p.ProductId,
                              CategoryName = c.CategoryName,
                              ProductName = p.ProductName,
                              UnitPrice = p.UnitPrice
                          };
            foreach (var productDto in result8)
            {
                Console.WriteLine("{0}  {1}",productDto.ProductName,productDto.CategoryName);
            }


        }

        private static void ClassicLinq(List<Product> products)
        {
            Console.WriteLine("--SQLLinq--");
            //Linq'i bu şekilde SQL gibi de yazabiliriz
            //Şartları ortaya yani liste İsminden sonra yazma opsiyonumuz bulunoyr bunda olduğu gibi(Products)

            var result7 = from p in products
                          where p.UnitInStock > 3
                          orderby p.ProductName
                          select p;
            foreach (var product in result7)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDesc(List<Product> products)
        {
            Console.WriteLine("--ThenBy---");
            //İçinde top geçenleri fiyatına göre sıraladık
            //Aynı fiyatta olnları tersten sırladık
            var result6 = products.Where(p => p.ProductName.Contains("top"))
                .OrderBy(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result6)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void WhereForOrderBy(List<Product> products)
        {
            Console.WriteLine("--OrderBy---");
            //İçinde top geçenleri fiyatına göre sıraladık
            var result5 = products.Where(p => p.ProductName.Contains("aptop")).OrderBy(p => p.UnitPrice);
            foreach (var product in result5)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllLinq(List<Product> products)
        {
            Console.WriteLine("---FindAll---");
            //FindAll ise varinin içinde geçen herhangi bir parçayı bulur
            //FindAll yerine Where daha çok tercih edilir
            var result4 = products.FindAll(p => p.ProductName.Contains("fon"));
            foreach (var product in result4)
            {
                Console.WriteLine(product.ProductName);
            }

        }

        private static void FindLinq(List<Product> products)
        {
            Console.WriteLine("--Find--");
            //Linq'te "Find" kaynaktan bir veri bulamaya yarar.
            // Değişken atamak gerekir
            //Atanan değişken üründeki bir obje olarak geri döner
            //Kullanmak için result3.PrductId gibi istenilen bir alan verilmelidir.
            //"p" olarak atanan takma isme lambda denir
            var result3 = products.Find(p => p.ProductId == 2);
            //Günlük hayatta misal olarak o aranan Id'nin detayına gitmek için kullanılır
            //Olmayan bir veri girilirse o değilken "result3" null olur
            Console.WriteLine(result3.ProductName);
        }

        private static void AnyLinq(List<Product> products)
        {
            Console.WriteLine("--Any--");
            //Linq'te "Any", listede ardığın bir veri var mı yok mu olduğunu öğrenmeye yarar
            //Bir değişken tanımlamak gereklidir "result2"
            //O değişkeni true veya false döndürür.
            var result2 = products.Any(p => p.ProductName == "Hacer Laptop");
            Console.WriteLine(result2);
        }

        private static void WithLinqExample()
        {
            static List<Product> GetProductsLinq(List<Product> products)
            //Linq ile kullanım
            {
                return products.Where(proInstence => proInstence.UnitPrice >
                    4000 && proInstence.UnitInStock > 2).ToList();
            }
        }

        private static void NotLinqExample()
        {
            static List<Product> GetProducts(List<Product> products)
            //Linq kullanmadığımızada bir filtre methodu

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
        }

        private static void WithLinq(List<Product> products)
        {
            Console.WriteLine("----Linq---------");
            //İlk etapta daha fazla veya zor gibi gelse de sorguya ekleme yapmaya başladıkça Linq kurtarıcı durumuna geçiyor

            var result = products.Where(pro => pro.UnitPrice > 5000 && pro.UnitInStock > 3);
            foreach (var pro in result)
            {
                Console.WriteLine("{0} Stok kodu: {1}", pro.ProductName, pro.UnitInStock);
            }
        }
        static void NotLinq(List<Product> list)
        {
            Console.WriteLine("-----Algoritmik-------");
            //Algoritmik, daha uzun karmaşık ve zor
            foreach (var pro in list)
            {
                if (pro.UnitPrice > 5000 && pro.UnitInStock > 3)
                {
                    Console.WriteLine(pro.ProductName);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //List'i Class içinde fakat methodların dışında verirsek globala hitap etmiş olur
        //Bu gibi durumlarda _ ile isimlendirilir aşağıda olduğu gibi
        List<Product> _products;
        //ctor tab tab ve "public InMemoryProductDal()"

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1,CategoryId = 1, ProductName = "Bardak",UnitPrice = 15,UnitInStock = 15},
                new Product{ProductId = 2,CategoryId = 1, ProductName = "Kamera",UnitPrice = 500,UnitInStock = 3},
                new Product{ProductId = 3,CategoryId = 2, ProductName = "Telefon",UnitPrice = 1500,UnitInStock = 2},
                new Product{ProductId = 4,CategoryId = 2, ProductName = "Klavye",UnitPrice = 150,UnitInStock = 65},
                new Product{ProductId = 5,CategoryId = 2, ProductName = "Fare",UnitPrice = 85,UnitInStock = 1}
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }
        public void Delete(Product product)
        {
            Product productToDeleteBad = null; //productToDelete'in heap'ini/ref nosunu sıfırladım ki kullanayaım
            foreach (var p in _products) //Foreach ile yazmak uzun yolu onun yerine LINQ'i kullanacağız
                                         //Lanugeage Integrated Query - LINQ
            {
                if (product.ProductId == p.ProductId)
                {
                    productToDeleteBad = p;
                }
            }
            //Lambda --- "=>" işareti
            //İki tarafata da "p" o an dolaştığım ürüne verdiğim takma ad

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);// Foreach ile aynı işlemi
                                                                                                       // görür bu satır
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
           //Aynı sql'de ki where koşlu gibi p'de ki CategoryId ile categoryId de eşlşenlerin bir listesini yap
           //categoryId'den sonra && gibi and or ekleyebiliriz
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan ürün id'sini bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //Ternary Opertor -- Hatırlatma
                return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public void Add(Product entity)
        {
            //Idispossable pattern implemeniton of c# -- girişteki using ile farkı
            //Bu şekilde using ile kullanma sebebimiz (normalde direkt new'leyebiliriz)
            //fakat fazla yer kapladığı için boşuna performans kaybına yola açacak fakat
            //bu şekilde işi bittiğinde garbage collector'a/ çöp toplayıcıya dirket silemesini
            //söylemiş oluyoruz 
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);    //Northwind cpntext'ine entity'i bağla
                addedEntity.State = EntityState.Added;  //Durumunu eklemeye ayarla
                context.SaveChanges();  //ekle
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);   
                deletedEntity.State = EntityState.Deleted;  
                context.SaveChanges(); 
            }
        }
    }
}

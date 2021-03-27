using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;

namespace DataAccess.Abstract
{
   //IEntityRepsitory kısıtlnması gerek çünkü onu inhertince olarak kullanan / onu implemenete eden
   //(misal IProductDal) farklı bir parmatler alabilir buna generic constraint deniyor.
   //bunun için <T> den sonra where ile kurallarımızı belirtiyoruz
   //class: referans tip olabilir demektir (Başka ref tipleri olabliceği için daralatmaya devam ediyoruz)
   //IEntity: IEntity olablir veya onu implemente eden biri olablir.
   //IEntity soyut bir şey olduğu için /nesne olmadığı için işe yaramıyor bize onu implemente
   //edenler lazım bunun için de kural olarak new'lenebilir olmasını isiyoruz ki
   //interface'ler new'lenemeyeceği için devre dışı klasın



   public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        //Expression, Business.ProductManager'da ki "GetAll" methoduna filtre
        //verebilmemizi sağlar.
        //Öğreniğin {return _productDal.GetAll(p=>p.CategolryId==3);}

        List<T> GetAll(Expression<Func<T, bool>> filter = null); //Filter=null, filtre vermeyebilirisin demektir
        T Get(Expression<Func<T, bool>> filter); //Bunu yapmak aşağıda commnedlediğim GetAllByCategory methoduna
                                                 //ihtiyacı ortadan kaldırıyor
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId);
    }
}

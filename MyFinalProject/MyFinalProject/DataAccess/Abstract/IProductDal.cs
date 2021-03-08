using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //I onun bir interface olduğunu söyler.
    //Product hangi tabloya işaret ettğini söyler.
    //Dal ise katmanını. Date Access Layer.
   public interface IProductDal
   {
       List<Product> GetAll();
       void Add(Product product);
       void Update(Product product);
       void Delete(Product product);

       List<Product> GetAllByCategory(int categoryId);


   }
}

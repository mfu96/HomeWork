using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //I onun bir interface olduğunu söyler.
    //Product hangi tabloya işaret ettğini söyler.
    //Dal ise katmanını. Date Access Layer.
    public interface IProductDal:IEntityRepository<Product>
    {
        

    }
}

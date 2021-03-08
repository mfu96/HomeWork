using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManger:IProductService
    {
        IProductDal _productDal;

        public ProductManger(IProductDal productDal)
        {
            _productDal = productDal;
        }

        
        public List<Product> GetAll()
        {
            //İş Kolları
            //Personel mi?
            //Yetkisi var mı?
            return _productDal.GetAll();

        }
    }
}

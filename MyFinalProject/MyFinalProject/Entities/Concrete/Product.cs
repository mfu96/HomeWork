using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    //Public eklediğin class'a diğer katmanlar da ulaşabilsin demek
    //Bir class'ın default'u/varsayılan şekli internal'dır
    //İnternal, bu class'a sadece bu/bulunduğu proje ulaşabilsin demeketir


    //internal class Product
    //{
    //}
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //Bak gördün mü bir s harhinin eksikliği (Unit"s"InStock) seni ne kadar geride bıraktı
        public decimal UnitPrice { get; set; }
    }
}

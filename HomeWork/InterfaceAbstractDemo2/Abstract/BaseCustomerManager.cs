using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo2.EntitiesNesneler;
using Customer = InterfaceAbstractDemo.Entities.Customer;

namespace InterfaceAbstractDemo2.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(EntitiesNesneler.Customer customer)    /*Virtual bunu ezebilmek anlamına geliyor
                                                                 *Yani Save Methodunun önüne başka bir
                                                                 * kod daha yazabilirim
                                                                 */
        {
            Console.WriteLine("Saved to db:" + customer.FirstName);
        }
    }
}

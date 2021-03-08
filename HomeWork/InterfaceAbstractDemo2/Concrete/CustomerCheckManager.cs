using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.EntitiesNesneler;
using MernisServiceReference1;

namespace InterfaceAbstractDemo2.Concrete
{
    
    //Bu class'ın amacı Starbucks veya Kahve Dünyası gibi sistemlere hiç 
    //bağlanmadan onalardan bağımsız bir şekilde bu kişi kontrolünü yapmak

    class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}

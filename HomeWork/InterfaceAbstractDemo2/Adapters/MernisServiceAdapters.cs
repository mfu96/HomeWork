using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.EntitiesNesneler;
using MernisServiceReference1;

namespace InterfaceAbstractDemo2.Adapters
{
    class MernisServiceAdapter:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)

        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();


            return client
            );
        }
    }
}

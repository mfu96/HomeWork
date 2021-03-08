using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.EntitiesNesneler;

namespace InterfaceAbstractDemo2.Concrete
{
    class KahveDunyasiCustomerManager:BaseCustomerManager
    {
        //İntialize etmeden önceki hali şöyle idi
        //ICustomerCheckService _customerCheckService;
        private ICustomerCheckService _customerCheckService;

        public KahveDunyasiCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        
    }
}

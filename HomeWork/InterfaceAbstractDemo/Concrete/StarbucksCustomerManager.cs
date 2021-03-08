using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    //Mernis doğrulamsı için ikinci interface'i implmente edeblirim bu 1. yöntem

    //public class StarbucksCustomerManager:BaseCustomerManger,ICustomerCheckService
    public class StarbucksCustomerManager : BaseCustomerManger

    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
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
                throw new Exception("Not a valid person/Kullanıcı bulunamadı");
            }
        }

      
    }
}

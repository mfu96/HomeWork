using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class UbisoftCustomerManager : BaseCustomerManger
    {
        private ICustomerCheckService _customerCheckService;

        public UbisoftCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

       

        public override void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Add(customer);
            }
            else
            {
                Console.WriteLine("Kandırıkçı seni");

            }
        }
    }
}

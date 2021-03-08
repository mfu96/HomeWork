using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class CustomerCheckManger:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;

        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference1;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManger:ICustomerCheckService
    {
       public bool CheckIfRealPerson(Customer customer)
       {
           return true;
       }
    }
}

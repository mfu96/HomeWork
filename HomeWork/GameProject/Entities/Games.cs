using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using BaseCustomerManger = GameProject.Abstract.BaseCustomerManger;

namespace GameProject.Entities
{
    public class Games:IEntity
    {
        public Games(BaseCustomerManger customerManger)
        {
            throw new NotImplementedException();
        }

        public string Name { get; set; }
        public int Price { get; set; }
    }
}

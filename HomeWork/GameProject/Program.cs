using System;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManger customerManger = new UbisoftCustomerManager(new CustomerCheckManger());
           
            customerManger.Add(new Customer
            {
                DateOfBirth = new DateTime(19,10,13),
                FirsName="Muhammed Furkan",
                LastName = "USLU",
                NationalityId = 36178871259
            });
            customerManger.Buy(Customer);
            

        }
    }
}

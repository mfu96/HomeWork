using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManger customerManger = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManger.Save(new Customer
            {
                DateOfBirth =new DateTime(1996,10,13),
                FirstName = "Muhammed Furkan",LastName = "Uslu",NationalityId = "36178871258"
            });
            Console.ReadLine();

        }
    }
}

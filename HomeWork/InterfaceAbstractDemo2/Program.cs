using System;
using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.Adapters;
using InterfaceAbstractDemo2.Concrete;
using InterfaceAbstractDemo2.EntitiesNesneler;

namespace InterfaceAbstractDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new KahveDunyasiCustomerManager(new MernisServiceAdapters());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1995,10,13),
                FirstName = "Muhammed Furkan",
                LastName = "USLU",
                NationalityId = "36178871258"
            });
        }
    }
}

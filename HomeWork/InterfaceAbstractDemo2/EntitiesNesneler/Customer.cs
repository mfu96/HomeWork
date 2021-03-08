using System;
using InterfaceAbstractDemo2.Abstract;

namespace InterfaceAbstractDemo2.EntitiesNesneler
{
    //Bir Customer nesnesi varsa ICustomer'i olmak zorunda
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
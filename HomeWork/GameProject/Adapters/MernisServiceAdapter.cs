using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference1;

namespace GameProject.Adapters
{
    class MernisServiceAdapter:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference1.KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId,
                customer.FirsName.ToUpper(),
                customer.LastName.ToUpper(),
                customer.DateOfBirth.Year);

        }
    }
}

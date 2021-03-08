using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.EntitiesNesneler;

namespace InterfaceAbstractDemo2.Concrete
{
    //Birinci kullanım bu şekilde inheritance yapark kullanmak ikinci kullanım ise 
    //Kahve Dünyası örneğinde
    public class StarbucksCustomerManager:BaseCustomerManager,ICustomerCheckService
    {
        public override void Save(Customer customer)
        {
            CheckIfRealPerson(customer);  //TR Gerçek Kişi olup olmadığını kontrol edin
            base.Save(customer);
        }
        /*Bir class'ın içine bir methot yazıyorsam şuna iyi karar vermek gerekli
         * bu yazdığım methot sadece bu calss'ımı ilgilendirecek herzaman
         * yani işin özü mernis doğrulamasını başka bir zaman Nero firması
         * da isteybilir bu da "Don't repead yourslef" pernsibine aykırı demektir         *
         */

        private void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        
        bool ICustomerCheckService.CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}

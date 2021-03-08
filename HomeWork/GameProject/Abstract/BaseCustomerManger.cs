using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public abstract class BaseCustomerManger:ICustomerService,IGames
    {
        public virtual void Add(Customer customer)
        {
            Console.WriteLine("Başarıyla Kaydedildi!/Saved Successfully!");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Başarıyla Güncellendi!/Saved Successfully!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Başarıyla Silindi!/Removed Successfully!"
            +"Tekrar gel lütfen!/Come again please!");

        }

        public void Buy(Games game)
        {
            Console.WriteLine("Satın alındı/Purchased");
        }

        public abstract void Buy(Customer customer);
    }
}

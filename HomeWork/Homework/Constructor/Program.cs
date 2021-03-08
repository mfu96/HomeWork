using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer{Id = 1,FirstName = "Muhammed Furkan",LastName = "USlu",City = "KOnya"};
            Customer customer3 = new Customer();     //Customer1'deki süslü parnatezin içi parametre değil
                                                     //hatta "customer1=customer3" tür
            customer3.Id = 3;
            customer3.FirstName = "Ömer";

            //Normal parantez () varsa bir methot var demektir giye genelleyebliriz
            //constructor'ı methotlara benzer
            Customer customer2 = new Customer(2,"Refik","Kalkan","Hakkari");
                            //Ama aşağıdaki constructor'da parametre var kantılamak gerekirse;
                            //Console.WriteLine(customer2.FirstName);
                            //Görülldüğü üzere çalışmadı
                            //Çalışması için constroctor'da değerleri set'etmek/ayaralamak gerekli
                            // Id=id
                            //FirstName=firstName  gibi.
        }

        class Customer
        {
            //İki tane constructor tanımladık ki customer1 ve 2 çalışsın
            //buna overloading deniyordu
            public Customer()
                //Buna default constructor denir
                //Arkaplanda eğer varsa yazdığın bi constructor
                //o çalışır yoksa bu default olarak çalışır
            {

            }
            public Customer(int id, string firstName, string lastName,string city)  
                                   
            {
                Console.WriteLine("Yapıcı Blok Çaşıştı");
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                City = city;

            }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public String LastName { get; set; }
            public string City { get; set; }
        }
    }
}

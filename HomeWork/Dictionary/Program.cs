using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Dicitonary de bizim simule ettiğimiz add remove vs methodtların hazır hali deyebiliriz
             *  Değer ve tipin girilmesi şarrttır
             *  Dinamik yapılıdır istedğimiz gibi eleman ekleyip çıkaratabliriz
             */

            Dictionary<string, int> kullanıcıAdVeYasi = new Dictionary<string, int>();
            kullanıcıAdVeYasi.Add("Muhammed Furkan Uslu",24);
            kullanıcıAdVeYasi.Add("Rahmi Korkmaz" ,24);
            kullanıcıAdVeYasi.Add("İbrahim Şimşek",29);

            foreach (var veriler in kullanıcıAdVeYasi)
            {
                Console.WriteLine(veriler);
            }

            var kacElemanVar = kullanıcıAdVeYasi.Count;
            Console.WriteLine("");
            Console.WriteLine("Eleman Sayısı =" + kacElemanVar);

            Console.WriteLine("");

            kullanıcıAdVeYasi.Remove("İbrahim Şimşek");

            foreach (var veriler in kullanıcıAdVeYasi)
            {
                Console.WriteLine(veriler);
            }

          

        }
    }
}

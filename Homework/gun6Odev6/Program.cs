using System;
using System.Security.Principal;

namespace gun6Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Yukluk malzeme1 = new Yukluk();
            malzeme1.Adi = "Çarşaf";
            malzeme1.onuzerindensicaktutmaorani = 1;
            malzeme1.Adedi = 5;

            Yukluk malzeme2 = new Yukluk();
            malzeme2.Adi = "Battaniye";
            malzeme2.onuzerindensicaktutmaorani = 6;
            malzeme2.Adedi = 4;

            Yukluk malzeme3 = new Yukluk();
            malzeme3.Adi = "Yorgan";
            malzeme3.onuzerindensicaktutmaorani = 7;
            malzeme3.Adedi = 5;

            Yukluk malzeme4 = new Yukluk();
            malzeme4.Adi = "Elektirikli Yorgan";
            malzeme4.onuzerindensicaktutmaorani = 9;
            malzeme4.Adedi = 1;

            Yukluk[] malzeme = new Yukluk[] {malzeme1, malzeme2, malzeme3, malzeme4};

            Console.WriteLine("-----FOR-----");
            for (int i = 0; i < malzeme.Length; i++)
            {
                Console.WriteLine("Malzeme Adı: " + malzeme[i].Adi);
                Console.WriteLine("10 Üzireinden Sıcak Tutma Oranı: " + malzeme[i].onuzerindensicaktutmaorani);
                Console.WriteLine("Malzeme Adedi" + malzeme[i].Adedi);
                Console.WriteLine("");
            }




            Console.WriteLine("----FOREACH-------");
            foreach (Yukluk malzemeler in malzeme)
            {
                Console.WriteLine("Malzeme Adı: "+ malzemeler.Adi);
                Console.WriteLine("10 Üzireinden Sıcak Tutma Oranı: "+ malzemeler.onuzerindensicaktutmaorani);
                Console.WriteLine("Malzeme Adedi"+malzemeler.Adedi);
                Console.WriteLine("");
            }

            Console.WriteLine("----While------");

            int j= 0;
            while (j < malzeme.Length) 
            {
                Console.WriteLine("Malzeme Adı: " + malzeme[j].Adi);
                Console.WriteLine("10 Üzireinden Sıcak Tutma Oranı: " + malzeme[j].onuzerindensicaktutmaorani);
                Console.WriteLine("Malzeme Adedi" + malzeme[j].Adedi);
                Console.WriteLine("");
                j++;
            }






        }
    }

    class Yukluk
    {
        public string Adi { get; set; }
        public int onuzerindensicaktutmaorani { get; set; }
        public int Adedi { get; set; }
    }
}

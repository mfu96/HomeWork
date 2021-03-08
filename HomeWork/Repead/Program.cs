using System;

namespace Repead
{
    class Program
    {
        static void Main(string[] args)
        {
            var deger = 20;
            if (deger < 20)
            {
                Console.WriteLine("Eşitlan işte");
            }
            else
            {
                Console.WriteLine("Değer Sağlanamdı");
            }

            var deger2 = 100;
            var deger3 = 120;


            var result = deger2<100 ? "Eşit Aslan" :"Değil";
            Console.WriteLine(result);

            int gun = (int) DateTime.Now.DayOfWeek;
            switch (gun)
            {
                case 1: Console.WriteLine("PZT");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çrş");
                    break;
            }


           



        }
    }
}

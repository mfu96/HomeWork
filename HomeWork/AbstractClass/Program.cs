using System;

namespace AbstractClass
{
    class Program
    {
        /*Anstract class'lar genel olarka interface'lerle aynı mantıkta çalışır
         *temel fark olarak bir class da birden fazla interface implemente
         * edileblirken abstract class'lar bir defa implemen edilir
         * interface'ler ulaşılmak için new'lenirken abstract class'lar
         * new'lenmez
         *
         */
        static void Main(string[] args)
        {
            MangerRoom mangerRoom = new MangerRoom();
            EmployeeRoom employeeRoom = new EmployeeRoom();
            mangerRoom.Chart = 400;
            mangerRoom.Desk = 1000;
            mangerRoom.Chair = 500;
            mangerRoom.OfficeMaterials();
            Console.WriteLine("------");

            employeeRoom.Desk = 80;
            employeeRoom.Chair = 100;
            employeeRoom.PhotoCopyMachine = 500;
            employeeRoom.OfficeMaterials();
        }
    }

    abstract class Office
    {
        public int Desk { get; set; }
        public int Chair { get; set; }
        public abstract void OfficeMaterials();

    }

    class MangerRoom : Office
    {
        public int Chart;
        public override void OfficeMaterials()
        {
            MangerRoom mangerRoom = new MangerRoom();
           

            Console.WriteLine("Müdür Masası: {0}{1}", Desk, "TL");
            Console.WriteLine("Müdür Sandalyesi: {0}{1}", Chair, "TL");
            Console.WriteLine("Tablo: {0}{1}", Chart, "TL");
        }

    }

    class EmployeeRoom:Office
    {
        public int PhotoCopyMachine;

        public override void OfficeMaterials()
        {
            EmployeeRoom employeeRoom = new EmployeeRoom();
          
            Console.WriteLine("Personel Masası: {0}{1}", Desk, "TL");
            Console.WriteLine("Personel Samdalyesi: {0}{1}", Chair, "TL");
            Console.WriteLine("Fotokopi Makinası: {0}{1}", PhotoCopyMachine, "TL");

        }
    }
}

using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("VAN");
            MyList<int> sehirler2 = new MyList<int>();  //Tip olarak ne verisek onu ister
            sehirler2.Add(65);
            MyList<string> sehirler3 = new MyList<string>();

        }

        class MyList<T>     //Generics calss
        {
            public void Add(T item)
            {

            }
        }
    }
}

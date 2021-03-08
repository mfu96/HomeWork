using System;
using System.Collections.Generic;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> IsletimSistemiVeTarihi = new Dictionary<string, int>();
            IsletimSistemiVeTarihi.Add("Windows 10 ",2015);
            IsletimSistemiVeTarihi.Add("Pardus",2005 );
            IsletimSistemiVeTarihi.Add("Ubuntu",2004);
            IsletimSistemiVeTarihi.Add("Rhapsody Mac OS X" ,2001);
            IsletimSistemiVeTarihi.Add("Raspberry Pi", 2012);

            foreach (var veriler in IsletimSistemiVeTarihi)
            {
                Console.WriteLine(veriler);
            }
        }
    }
}

using System;

namespace Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            // (Inheritance (Miras) ) Sınıflarda kullanılan ortak üyelerini bir sınıfta toplanarak diğer sınıflara devredilmesidir...

            // Mirasi biri sınıfın kalıtım yoluyla başka sınıftan üyelerini devralmasıdır

            // Inheritance konusu içerisinde;
            // Abstraction
            // Poliymorphism
            // Multiple Inherince konularını barındırır..


            // i 


            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Furkan";
            ogr.Yasi = 24;

            Ogrentmen ogt = new Ogrentmen();
            ogt.Adi = "Ekrem";
            ogt.Yasi = 33;


            Console.WriteLine("Hello World!");
        }
    }
}

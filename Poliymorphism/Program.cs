using System;

namespace Poliymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Çok biçimlilik (Poliymorphism) => base sınıfdan alınan üyelerin alt sınıfta farklı davranabilme yaklaşımıdır..

            Ogrenci ogr = new Ogrenci();
            

            Ogretmen ogrt = new Ogretmen();

            Console.WriteLine("Öprenci derki " +ogr.GenelDusunce());
            Console.WriteLine("Hoca derki " +ogrt.GenelDusunce());

            Console.WriteLine("Öğrenci derki "+ ogr.DersDusunce());
            Console.WriteLine("Hoca derki " + ogrt.DersDusunce());

            Insan i = ogr;
            Insan ii = ogrt;


            Console.WriteLine("Öğrenci derki "+ i.DersDusunce());
        
            Console.WriteLine("Hoca derki " + ii.DersDusunce());

            Console.ReadKey();
        }
    }
}

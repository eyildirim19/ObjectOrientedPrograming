using System;

namespace ClasssesOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.adi = "Furkan";
            ogr.vize = 50;
            ogr.final = 60;

            Ogrenci ogr1 = new Ogrenci();
            ogr1.adi = "Evren";
            ogr1.vize = 40;
            ogr1.final = 70;

            // ogr1.ortalama = 100; private üye olduğu için Orenci classı dışından erişilemez...

            Console.WriteLine($"{ogr.adi}  = {ogr.Ortalama()} {ogr.HarfNot()}");
            Console.WriteLine($"{ogr1.adi} = {ogr1.Ortalama()} {ogr1.HarfNot()}");

            Console.ReadKey();
        }
    }
}
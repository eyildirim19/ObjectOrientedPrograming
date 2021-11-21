using System;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            // öğrenci notu 0 ile 100 arasında girilebilir...bu değerleri alabilmek için nesnin notunu set ederken kontrol yapmak gerekir...

            // Not : private olduğu için buradan değer atanamaz
            Ogrenci ogr = new Ogrenci();
            // ogr.Not = 200;
            ogr.SetVize(200);
            ogr.Final = 200;

            Ogrenci ogr1 = new Ogrenci();
            // ogr1.Not = -1;
            ogr1.SetVize(-1);
            ogr1.Final = -1;

            Ogrenci ogr2 = new Ogrenci();
            // ogr2.Not = 100;
            ogr2.SetVize(100);
            ogr2.Final = 100;

            Console.WriteLine($"Girilen Not= {ogr.GetVize()} Fİnal = {ogr.Final}");
            Console.WriteLine($"Girilen Not= {ogr1.GetVize()} Fİnal = {ogr1.Final}");
            Console.WriteLine($"Girilen Not= {ogr2.GetVize()} Fİnal = {ogr2.Final}");

            // todo:  Encapsulation nedir araştırınız. döküman şeklinde hazırlayıp github'a ekleyiniz..

            Console.ReadKey();
        }
    }
}

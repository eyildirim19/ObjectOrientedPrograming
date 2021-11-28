using System;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface!");


            // OOP'nin bütün yaklaşımları classları daha etkili kullanmak, kod tekrarını azaltmak belirli prensiplere göre kod yazmaktır...

            // class => class içerisinde farklı tipleri barındıran, kendimize ait tipler oluşturduğumuz, varlık modellediğimiz oop'nin en temel yapısıdır...

            // Interface = sadece özellik (üye) tanımlanan varlıklardır. Interfaceler çok biçimlilik ve soyutlama yaklaşımını uygulamak için kullanılır..
            // Soyutlama => interfaceler instance alınmak için (nesne oluşturmak) kullanıılmazalar
            // Çok biçimlik => interrace üyeleri sadece tanım yapmak için kullanılır. Kendi içerisinde üyelerin gövdeleri tanımlanamaz.
            // interfaceler sadece tanım yapmak için kullanılır. bu tanımlar sınıflara yetenek kazandırmak içindir.amaç  kod tekrarını engellemektir. 
            // c# dilinde classlar sadece bir classtan türeyebilir.

            // interfaceler projemize sağ tık yapıp add => new item ile gelen pencereden Interface sablonu seçilerek eklenir

            // Not : interface isimleri büyük I ile başlar. 

            Ogrenci ogr = new Ogrenci();
            ogr.Yas = 24;
            ogr.Ad = "Furkan";
            ogr.SoyAd = "Tunç";

            Console.WriteLine(ogr.FullAdd);
            Console.WriteLine(ogr.DogumYili);
            
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Yas = 33;
            ogretmen.Ad = "Ekrem";
            ogretmen.SoyAd = "YILDırım";

            Console.WriteLine(ogretmen.FullAdd);
            Console.WriteLine(ogretmen.DogumYili);
            

            Console.ReadKey();
        }
    }
}
using System;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface!");

            #region tanim


            // OOP'nin bütün yaklaşımları classları daha etkili kullanmak, kod tekrarını azaltmak belirli prensiplere göre kod yazmaktır...

            // class => class içerisinde farklı tipleri barındıran, kendimize ait tipler oluşturduğumuz, varlık modellediğimiz oop'nin en temel yapısıdır...

            // Interface = sadece özellik (üye) tanımlanan varlıklardır. Interfaceler çok biçimlilik ve soyutlama yaklaşımını uygulamak için kullanılır..
            // Soyutlama => interfaceler instance alınmak için (nesne oluşturmak) kullanıılmazalar
            // Çok biçimlik => interrace üyeleri sadece tanım yapmak için kullanılır. Kendi içerisinde üyelerin gövdeleri tanımlanamaz.
            // interfaceler sadece tanım yapmak için kullanılır. bu tanımlar sınıflara yetenek kazandırmak içindir.amaç  kod tekrarını engellemektir. 
            // c# dilinde classlar sadece bir classtan türeyebilir.

            // interfaceler projemize sağ tık yapıp add => new item ile gelen pencereden Interface sablonu seçilerek eklenir

            // Not : interface isimleri büyük I ile başlar. 
            #endregion
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
            ogretmen.Maas = 2;

            Console.WriteLine(ogretmen.FullAdd);
            Console.WriteLine(ogretmen.DogumYili);
            Console.WriteLine(ogretmen.IsyeriAdresi());

            SatisDanismani danisman = new SatisDanismani();
            danisman.Ad = "Erhan";
            danisman.SoyAd = "Denem";
            danisman.Maas = 1;

            Console.WriteLine(danisman.FullAdd);
            Console.WriteLine(danisman.IsyeriAdresi());

            //  
            AdressGoster(ogretmen);
            AdressGoster(danisman);


            Console.ReadKey();
        }

        static void AdressGoster(ICalisan calisan)
        {
            Console.WriteLine(calisan.Maas);
            Console.WriteLine(calisan.IsyeriAdresi());
        }
    }
}
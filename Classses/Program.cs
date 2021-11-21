using System;

namespace Classses
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region tanim
            // Object Orinented Programming(OOP) = Nesne Yönelimli Programlama
            // bir programlama modelidir...gündelik hayattaki varlıkların programalama ortamında modellenebilmesidir..

            // Yaklaşımlar;
            // Encapsulation (kapsülleme)
            // Abstraction (Soyutlama)
            // Polimorphism (Çok biçimlilik)

            // Amaç;
            // bir kere yaz, sürekli kullan... (kod tekrarnının önlenmesi...)


            // Class (Sınıf) => Classlar uygulama içerisinde soyut varlıklar oluşturmak için kullanılan kod bloklarıdır. Amacı içerisinde birden fazla değişkeni, metodu tutmak için kullanılır. Komutlar bir sınıf içerisinde tasarlanarak modülerlik sağlanır..Örnek olarak Convert, Array, Console sınıfları. Her bir sınıf içerisinde kendiyle ilişkili komutları barındırır.. Bir sınıf oluşturmak için projeye sağ tık yapılır, add new item seçeneği ile gelen pencereden class dosyası sçeilerek projeye eklenir...

            // eğer metotlar arabanın bir parçasıysa class arabanın bütünüdür..


            // Not : class tipinde oluşturulan değişkenlere nesne(object) denir..sınıf üyerine  nesneadi. ile erişilir.. nesneler üzerinde işlem yapabilmek için nesnelerin instance (örneK) olması gerekir. instance'lar new komutu oluşturulur...
            #endregion

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.adiSoyAdi = "Furkan";
            ogrenci.cinsiyet = 'E';
            ogrenci.yas = 20;

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.adiSoyAdi = "Bahar";
            ogrenci1.cinsiyet = 'K';
            ogrenci.yas = 18;

            Console.WriteLine(ogrenci.adiSoyAdi);
            Console.WriteLine(ogrenci1.adiSoyAdi);

            Console.ReadKey();
        }
    }
}

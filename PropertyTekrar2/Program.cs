using System;

namespace PropertyTekrar2
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen değerler 0 ile 100 arasında olmalıdır...
            Console.WriteLine("Kaç öğrenci girilecek...");
            int n = Convert.ToInt32(Console.ReadLine());
      
            Ogrenci[] ogrencis = new Ogrenci[n];
            for (int i = 0; i < n; i++)
            {
                Ogrenci ogr = new Ogrenci();
                Console.WriteLine($"{i}. Adı girniz");
                ogr.Adi = Console.ReadLine();

                Console.WriteLine($"{i}. Vize giriniz");
                ogr.Vize = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"{i}. Final giriniz");
                ogr.Final = Convert.ToSingle(Console.ReadLine());

                ogrencis[i] = ogr;
            }

            // ogrenci ortalamasını ekrana yazdır..

            foreach (var item in ogrencis)
            {
                Console.WriteLine($"{item.Adi}  = {item.HarfNotu}");
            }

            Console.ReadKey();
        }
    }
}

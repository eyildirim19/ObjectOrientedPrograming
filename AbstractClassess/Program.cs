using System;

namespace AbstractClassess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract => soyutlama
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = "Furkan";
            ogr.Yas = 24;
            ogr.Not = 50;

            Hoca h = new Hoca();
            h.Ad = "Ekrem";
            h.Yas = 33;
            h.Maas = 500;

            Insan ii = h; // yeni bir instance almıyoruz. h 'nin instancenını atıyoruz...

            //Insan i = new Insan(); // Insan abstract bir sınıf olduğu için instance alınamaz..
            //i.Ad = "Semiha";
            //i.Yas = 18;

            Console.ReadKey();
        }
    }
}


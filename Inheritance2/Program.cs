using System;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "furkan";
            ogr.Not = 60;

            Ogretmen hoca = new Ogretmen();
            hoca.Adi = "Ekrem";
            hoca.IseGirisTarihi = DateTime.Now;

            // i nesnesi ogr nesenin atası olduğu için referansını tutabilir...
            byte b = 1;
            int a = b;
            Insan i = ogr;
            Insan i1 = hoca;

            BilgiGoster(i);
            BilgiGoster(i1);
            Console.ReadKey();
        }
        static void BilgiGoster(Insan i)
        {
            int a = 300;
            byte b = (byte)a;

            Console.WriteLine(i.Adi); // i referansında adı yaz

            if (i is Ogretmen)
            {
                Ogretmen ogt = (Ogretmen)i;
                Console.WriteLine(ogt.IseGirisTarihi);
            }
            else if(i is Ogrenci)
            {
                Ogrenci og = (Ogrenci)i; // insanda saklanan refernası og'ye set et..
                Console.WriteLine(og.Not);
            }
        }
    }
}

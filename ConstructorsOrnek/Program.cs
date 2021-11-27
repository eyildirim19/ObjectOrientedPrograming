using System;

namespace ConstructorsOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new("Ekrem", 47, 65);
            Ogrenci ogr2 = new Ogrenci("Furkan", 60, 70);
            Ogrenci ogr3 = new Ogrenci("Suna", 40, 70);
            Ogrenci ogr4 = new Ogrenci("Deneem", 0, 0);

            // ogr3.Ortalama = 55; // => ortalam değiştirilmemelidir...

            Console.WriteLine(ogr.Ortalama);
            Console.WriteLine(ogr2.Ortalama);
            Console.WriteLine(ogr3.Ortalama);
            Console.WriteLine(ogr4.Ortalama);

            Console.ReadKey();
        }
    }
}

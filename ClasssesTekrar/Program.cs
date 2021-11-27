using System;

namespace ClasssesTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            // n(10) adet öğrenci için bu bilgiler istenecek...

            #region old
            //string adi = "Suna";
            //char cinsiyet = 'K';
            //float not = 30;

            //string adi1 = "Furkan";
            //char cinsiyet1 = 'E';
            //float not1 = 50;

            //string adi2 = "Bahar";
            //char cinsiyet2 = 'K';
            //float not2 = 50;

            //string[] ogrenciler = new string[3];
            //char[] cinsiyetler = new char[3];
            //float[] notlar = new float[3];

            //ogrenciler[0] = adi;
            //ogrenciler[1] = adi1;
            //ogrenciler[2] = adi2;

            //cinsiyetler[0] = cinsiyet;
            //cinsiyetler[1] = cinsiyet1;
            //cinsiyetler[2] = cinsiyet2;

            //notlar[0] = not;
            //notlar[1] = not1;
            //notlar[2] = not2;

            #endregion

            Ogrenci ogr = new Ogrenci();
            ogr.adi = "Suna";
            ogr.cinsiyet = 'K';
            ogr.not = 30;

            ogr.bilgiGoster();
            
            Console.ReadKey();
        }
    }
}

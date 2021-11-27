using System;

namespace PropertyTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Otomobil ot = new Otomobil();
                ot.Marka = "TOYOTA";
                ot.Model = "COROLLA";
                ot.Fiyat = 20000;
                ot.Yakit = "DİZEL";

                Console.WriteLine(ot.Yakit);


                // DİZEL,BENZİN, LPG HARİCİ YAKIT TÜRLERİ KABUL EDİLMESİN, uygulama hata versin..
                Otomobil ot2 = new Otomobil();
                ot2.Marka = "TOYOTA";
                ot2.Model = "AURIS";
                ot2.Fiyat = 300000;
                ot2.Yakit = "DEMO";

                Console.WriteLine(ot2.Yakit);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); // hata mesajını göster...
            }
            Console.ReadKey();
        }
    }
}
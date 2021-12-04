using System;

namespace Interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            Onder ond = new Onder();
            Furkan frk = new Furkan();
            Suna sn = new Suna();
            Evren evrn = new Evren();
            Bahar bhr = new Bahar();

            // Öğrencilerin düşüncelerini main dışındaki bir metot ile gösterelim..
            Dusunce(ond);
            Dusunce(frk);
            Dusunce(sn);
            Dusunce(evrn);
            Dusunce(bhr);


            Console.ReadKey();
        }

        // Dusunce metodunun IOgrenci tipindeki parametresi sayesinde Yeni bir öğrenci geldiğinde bu metodu geliştirmeyeceğiz. çünkü eğer öğren IOgrenciden türerse IOgrenci o öğrenci çalışabilir...
        static void Dusunce(IOgrenci ogrenci) // IOgrenci tipinde gönderilen instance için çalışır...
        {
            ogrenci.Dusunce();
        }

        #region Old
        static void DusunceF(Furkan f)
        {
            f.Dusunce();
        }

        static void DusunceO(Onder o)
        {
            o.Dusunce();
        }

        static void DusunceS(Suna s)
        {
            s.Dusunce();
        }

        static void DusunceE(Evren e)
        {
            e.Dusunce();
        }
        #endregion
    }
}

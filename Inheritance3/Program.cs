using System;

namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil ot = new Otomobil();
            ot.Marka = "TOYOTA";
            ot.Model = "COROLLA";
            ot.Yakit = "DİZEL";
            ot.IsHususi = false;

            Otomobil ot1 = new Otomobil();
            ot1.Marka = "OPEL";
            ot1.Model = "CORSA";
            ot1.Yakit = "BENZİN";
            ot1.IsHususi = true;

            Kamyon km = new Kamyon();
            km.Marka = "FORD";
            km.Model = "1450";
            km.Yakit = "DİZEL";
            km.YukKapasitesi = 50;

            Arac[] aracs = new Arac[3]; // 3 elemanlı araç dizisi
            aracs[0] = ot;
            aracs[1] = ot1;
            aracs[2] = km;

            AracIslemleri islem = new AracIslemleri(aracs);
            islem.BilgiGoster();

            Console.ReadKey();
        }
    }
}

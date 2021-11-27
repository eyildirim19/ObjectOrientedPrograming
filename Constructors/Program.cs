using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tanimlar
            // Not => notları tuttuğumuz class..
            // nt ve nt1 not sınıfından üretilen nesne...(değişken)

            // class ve nesne arasındaki fark class geneldir (soyut) nesneler ise özeldir (somut)

            // bir classtan nesne olutşurma işlemi;
            // Class nesneAdi;

            // new Not() ifadesi =>yeni nesne oluşturmak için kullanılır..yani instance almak için kullanılır. bellekte yeni bir alan(referans) açar..
            #endregion
            int a = 5;
            Not nt = new Not(); //Not sınıfın constructor'ini tetikliyoruz...
            nt.Vize = 50;
            nt.Final = 50;

            Not nt1 = new Not();
            nt1.Vize = 60;
            nt1.Final = 80;

            Not nn = nt1; // nt1'İn referansı nn'ye atandı. Bunlar reference type oldukları için nn ve nt nesnesinin referenceları aynıdır.
            nn.Vize = 100; // referanstki Vize değişir. Bu iki nesne bellekte aynı yere baktıkları için her ikisinin değeri değişir...
            Console.WriteLine(nt1.Vize); // ekran çıktısı nedir????

            Not nt2 = new Not(55, 67); // overload edilen ctrodan instance aldık..
            Console.WriteLine(nt2.Vize); // vizeyi ekrana yazdır..

            Console.ReadKey();
        }
    }
}
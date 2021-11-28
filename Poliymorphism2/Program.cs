using System;

namespace Poliymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract üyeler ile polimorphism...");

            Kus k = new Kus();
            Console.WriteLine(k.Ses());

            Kedi k1 = new Kedi();
            Console.WriteLine(k1.Ses());

            Console.WriteLine("*********************");

            HayvanlarAlemi[] hayvanciklar = new HayvanlarAlemi[2];
            hayvanciklar[0] = k;
            hayvanciklar[1] = k1;
            foreach (var item in hayvanciklar)
            {
                Console.WriteLine(item.Ses());
            }

            Console.ReadKey();
        }
    }
}

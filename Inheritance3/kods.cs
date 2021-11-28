using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    public class Arac
    {
        public string Marka { get; set; }

        public string Model { get; set; }

        public string Yakit { get; set; }
    }

    public class Otomobil : Arac
    {
        public bool IsHususi { get; set; }
    }

    public class Kamyon : Arac
    {
        public float YukKapasitesi { get; set; }
    }

    public class AracIslemleri
    {
        public AracIslemleri(Arac[] araclar) // arac dizisi ister, gelen diziye üyeye atar...
        {
            aracs = araclar;
        }

        private Arac[] aracs { get; set; }


        public void BilgiGoster()
        {
            foreach (var item in aracs)
            {
                Console.WriteLine(item.Marka);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Yakit);

                if (item is Kamyon)
                {
                    Kamyon k = (Kamyon)item; // item'İ kamyon olarak çıkart
                    Console.WriteLine(k.YukKapasitesi);
                }
                else if (item is Otomobil)
                {
                    Otomobil o = (Otomobil)item;
                    Console.WriteLine(o.IsHususi);
                }
            }
        }
    }

}


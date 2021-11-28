using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassess
{
    // Abstract class => base sınıfların soyutlandırılmasıdır.. sadece miras vermek için kullanılan sınıflardır.Abstract sınıflarda instance alınamaz...
    public abstract class Insan
    {
        public string Ad { get; set; }
        public byte Yas { get; set; }
    }

    public class Ogrenci : Insan
    {
        public int Not { get; set; }
    }

    public class Hoca : Insan
    {
        public decimal Maas { get; set; }
    }
}

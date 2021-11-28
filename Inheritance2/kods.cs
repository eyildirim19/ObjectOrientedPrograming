using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    // kods classı oluşturup siçerisindeki class komutunu siliip aynı şekilde yazabilirsiniz...
    public class Insan
    {
        public string Adi { get; set; }
    }

    public class Ogrenci : Insan
    {
        public float Not { get; set; }
    }

    public class Ogretmen : Insan
    {
        public DateTime IseGirisTarihi { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    // interface üyelerini implemente edebilmek için sınıf üzerine gelip yanan lambaya sağ tık yapıp implement interface seçeneğiile metotları alabilirsiniz....
    public class Ogretmen : Insan, ICalisan
    {
        public decimal Maas { get; set; }

        public string IsyeriAdresi()
        {
            return "A Lokasyonu...";
        }
    }

    public class SatisDanismani : Insan, ICalisan
    {
        public decimal Maas { get; set; }

        public string IsyeriAdresi()
        {
            return "B Lokasyonu...";
        }
    }
}

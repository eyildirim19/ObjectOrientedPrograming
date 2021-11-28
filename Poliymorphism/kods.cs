using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliymorphism
{
    public class Insan
    {
        public string GenelDusunce()
        {
            return "Yaşamak çok güzel";
        }

        // virtual(sanal) =>  alt sınıflar tarafından ezilebilen üyelerdir..
        public virtual string DersDusunce()
        {
            return "Hoca anlatamıyor";
        }
    }

    public class Ogrenci : Insan
    {

    }

    public class Ogretmen : Insan
    {
        // override => üst sınıftan gelen virtual üyeleri ezmek için kullanılır...
        // üst sınıftan gelen virtual üyeleri override komutu ile ezebiliriz

        public override string DersDusunce()
        {
            return "Öğrenci anlamıyor...";
        }
    }
}

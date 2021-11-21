using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssesOrnek
{
    // Sınıfların default erişim seviyeleri internal'dır..
    // private ve protected aynı seviyede
    // internal ve public aynı seviyedir. (ikiside geneldir. internal proje içerisinde public her yerde(farklı projelerde) erişilebilir..
    public class Ogrenci
    {
        // Sınıf üyelerine (genelde fieldlardır) kontrollü erişimi sağlar. sınıf içerisinde işlem yaparken sınıf dışında işlem yaptırılmaz...
        public string adi;
        public float vize;
        public float final;
        private float ortalama; // Encapsülation... 
        // not : sınıf üyesi fieldlara sınıf seviyesinde erişilemez..üyelere erişmek için metot veya property kullanılmalıdır..
        //public float ortalama = vize * 0.4f + final * 0.6f;

        public float Ortalama()
        {
            ortalama = vize * 0.4f + final * 0.6f;
            return ortalama;
        }

        public string HarfNot()
        {
            if (ortalama >= 80 && ortalama < 100)
                return "AA";
            else if (ortalama > 60 && ortalama < 80)
                return "BB";
            else if (ortalama >= 40 && ortalama < 60)
                return "CC";
            else
                return "FF";
        }
    }
}
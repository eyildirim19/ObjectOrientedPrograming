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
        public string adi;
        public float vize;
        public float final;

        // not : sınıf üyesi fieldlara sınıf seviyesinde erişilemez..üyelere erişmek için metot veya property kullanılmalıdır..
        //public float ortalama = vize * 0.4f + final * 0.6f;

        public float Ortalama()
        {
            return vize * 0.4f + final * 0.6f;
        }

        public string HarfNot(float deger)
        {
            float ort = deger;

            if (ort >= 80 && ort < 100)
                return "AA";
            else if (ort > 60 && ort < 80)
                return "BB";
            else if (ort >= 40 && ort < 60)
                return "CC";
            else
                return "FF";
        }
    }
}
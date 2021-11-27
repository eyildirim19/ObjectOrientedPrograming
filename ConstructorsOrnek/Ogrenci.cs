using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsOrnek
{
    public class Ogrenci
    {
        // ctor tab tab yaparsanız constructor tanımlanacaktır..

        // prop tab tab yaparsnız property tanımlanacaktır
        public Ogrenci(string adi, float vize, float final)
        {
            Adi = adi;

            #region if
            /*
            if (vize >= 0 && vize <= 100) // tek satırda {} kullanımına gerek yok..
                Vize = vize;
            if (final >= 0 && final <= 100)
                Final = final;
            */
            #endregion

            Vize = vize >= 0 && vize <= 100 ? vize : 0;
            Final = final >= 0 && final <= 100 ? final : 0;

            //ortalamayı hesaplayalım...
            Ortalama = vize * 0.4f + final * 0.6f;
        }

        public string Adi { get; set; }

        public float Vize { get; set; }

        public float Final { get; set; }

        public float Ortalama { get; private set; } // sadece sınıf içerisinde set edilebilir...
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTekrar2
{
    // Not : eğer propertynin herhangi bir bloğu ezilirse, diğer bloğu hata verir. çünkü propertyler get ve set değiştirilmediği sürece gizli field tutarlar. eğer bu iki bloktan biri değiştirilirse o gizli field kaybolur...
    public class Ogrenci
    {
        // hem değer tutar, hemde işaret eidlene değere erişm sağlar..
        public string Adi { get; set; }

        private float vize; // değer tutma
        public float Vize // vizeye kontrollü erişim yapar
        {
            get
            {
                return vize;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    vize = value;
                }
            }
        }

        private float final;
        public float Final
        {
            get
            {
                return final;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    final = value;
                }
            }
        }


        public string HarfNotu
        {
            get
            {
                float ort = vize * 0.4f + final * 0.6f;

                if (ort>50)
                {
                    return "AA";
                }
                else
                {
                    return "FF";
                }
            }
        }

    }
}

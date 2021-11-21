using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class Ogrenci
    {
        /*         
        Sınıf üyeleri;

        field =  değer tutan program varlığı
        metot = işlem yapan program varlığı
        properties = c# 3.0 ile gelmiştir... field ve metot karışımıdır...Bundan sonraki süreçte gerekmedikçe field kullanmayacağız...property filed görevi görürler... propertyler içerisinde get ve set metodu barından özel varlıklardır. get ve set metodu property'inin işaret ettiği fielda değer atar, değer okur.
         */

        //public string Adi { get; set; } // property...

        // propertyi anlamak için encapsulation ve get ve set metotları anlamak gerekir...

        // Encapsulation => üyeler içeriye açık dışarıya kapalı..
        private int vize;
        public void SetVize(int n) // metodun tek bir görevi var sadece değer set etmek. bu yüzden geri dönüş tipi voiddir.
        {
            if (n >= 0 && n <= 100)
            {
                vize = n;
            }
        }

        public int GetVize() // metodun görevi geriye saklanan notu dönmek olduğıu için dönüş tipi inttir...
        {
            return vize;
        }

        // Encapsulation'ı property ile yapıyorz...
        private int final;
        public int Final
        {
            get // gizli bir mettotur. geriye property tipinde değer döner
            {
                return final;
            }
            set // gizli bir void metottur. parametre alır. parametre value'dan gelir..
            {
                if (value >= 0 && value <= 100)
                {
                    final = value;
                }
            }
        }
    }
}

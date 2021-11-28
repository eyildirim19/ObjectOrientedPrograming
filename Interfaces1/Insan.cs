using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    public class Insan
    {
        private int dogumYili; // field
        private int yas; // field
        public int Yas
        {
            get { return yas; }

            set
            {

                yas = value;
                dogumYili = DateTime.Now.AddYears(-yas).Year; // şimdiki yıldan yaş değerini çıkarır.. .Year ile tarihteki yılı alır
            }
        }

        public int DogumYili
        {
            get
            {
                return dogumYili;
            }
        }

        public string Ad { get; set; }

        public string SoyAd { get; set; }

        public string FullAdd
        {
            get
            {
                return $"{Ad} {SoyAd.ToUpper()}"; // adı soyadı birleştir ve geri dön...
            }
        }



    }
}

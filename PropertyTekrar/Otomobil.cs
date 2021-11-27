using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTekrar
{
    class Otomobil
    {
        // marka, model, fiyat, yakıt
        //  private string marka;
        //private string model;
        //public decimal fiyat;
        private string yakit;
        // propertyler fieldlara değer atamak (set) ve değer okumak (get) için kullanılır...
        // propertyler değerleri gizli fieldda tutarlar..
        public string Marka { get; set; }

        public string Model { get; set; }

        public decimal Fiyat { get; set; } // gizli field tutar.. atanan ve okuna değer bu gizli field üzerinden yapılır..

        public string Yakit
        {
            get
            {
                return yakit; // fieıldın değerini dön...
            }
            set
            {
                if (value == "DİZEL" || value == "BENZİN" || value == "LPG")
                {
                    yakit = value; // gelen değeri yakit field'Inda tut...
                }
                else
                {
                    throw new Exception("yakıt tipi hatalı...");// hata fırlat....
                }
            }
        }// gizli field tutar.. atanan ve okuna değer bu gizli field üzerinden yapılır..
    }
}

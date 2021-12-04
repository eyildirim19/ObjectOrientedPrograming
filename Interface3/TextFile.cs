using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    public class TextFile : BaseFile, IDosya
    {
        // BU SINIFA CTOR İLE GELEN PARAMETREYİ BASE SINIFIN CTROUNA GÖNDERİYORUZ....
        public TextFile(string dosyaIsmi)
            : base(dosyaIsmi)
        {
        }

        public void Read()
        {
            Console.WriteLine($"... pathindeki {FileName} dosya okundu...");
        }
    }
}
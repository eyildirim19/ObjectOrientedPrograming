using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    public class ExcelFile : BaseFile, IDosya
    {
        // base =>miras alınan sınıf anlamına gelir...
        public ExcelFile(string dosyaIsmi)
            : base(dosyaIsmi)
        {
        }

        public void Read()
        {
            Console.WriteLine($"... pathindeki {FileName} dosya okundu excel formatında okunmuştur..");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    // FileOperation sınıfı bütün dosya sistemleri için çalıştırılan bir sınıftır.

    public class FileOperation
    {
        #region old
        //public TextFile fileText { get; set; }

        //public ExcelFile fileExcel { get; set; }

        //public void ReadFile()
        //{
        //    fileText.Read();
        //}

        //public void ReadFileExcel()
        //{
        //    fileExcel.Read();
        //}
        #endregion
        
        // Interface'den türeyen sınıflaru bu property'de tutuyoruz..
        public IDosya Dosya { get; set; }

        public void Oku()
        { 
            // Interface üzerinden metodu çalıştırıyoruz....
            Dosya.Read();
        }

    }
}
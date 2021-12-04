using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    // her iki file sınıfının yaptığı işlemi yapar...
    public class BaseFile
    {
        public BaseFile(string fName)
        {
            FileName = fName;
        }
        public string FileName { get; set; }
    }
}

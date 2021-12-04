using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    public class XmlFile : BaseFile, IDosya
    {
        public XmlFile(string xName)
            : base(xName)
        {

        }

        public void Read()
        {
            Console.WriteLine($"Sabah Sabah { FileName} dosyasımı okunur....");
        }
    }
}

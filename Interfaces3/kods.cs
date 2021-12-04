using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces3
{
    // proje deki inteface ve kodların bulunduğu dosya...
    public interface IOgrenci
    {
        void Dusunce();
    }

    // implemente etmek, interfaceden gelen üyenin miras alan sınıf tarafından tamamlanması demektir...
    public class Furkan : IOgrenci
    {
        public void Dusunce()
        {
            Console.WriteLine("interface çok zor...");
        }
    }

    public class Onder : IOgrenci
    {
        public void Dusunce()
        {
            Console.WriteLine("OOP genel olarak güzel");
        }
    }

    public class Suna : IOgrenci
    {
        public void Dusunce()
        {
            Console.WriteLine("Konular fena değil");
        }
    }
    public class Evren : IOgrenci
    {
        public void Dusunce()
        {
            Console.WriteLine("Uheritance ve çok biçimlikik konu");
        }
    }

    public class Bahar : IOgrenci
    {
        public void Dusunce()
        {
            Console.WriteLine("Hoca sürekli farklı çalıştırır");
        }
    }
}
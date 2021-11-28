using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    public class Arac
    {
        public string Marka { get; set; }

        public string Model { get; set; }

        public string Yakit { get; set; }
    }

    public class Otomobil : Arac
    {
        public bool IsHususi { get; set; }
    }

    public class Kamyon : Arac
    {
        public float YukKapasitesi { get; set; }
    }
}


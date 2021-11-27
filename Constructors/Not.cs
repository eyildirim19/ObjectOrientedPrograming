using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Not
    {
        #region tanim...
        // Constructor (ctor)=> sınıfların yapıcı metotlarıdır. Bir sınıftan instance alındığında tetiklenir. Bİr sınıfın eğer constructorı olmazsa o sınıftan instance alınamaz.. Bunun için ctorlar sınıf içerisinde default gizli tanımlı gelirler. eğer ctor yazarsak bu default tanımı ezmiş oluruz... Ctorlar metottur. Geriye dnüş tipi olmayan adı sınıf ismi ile aynı olmak zorunda olan metotlardır. new ifesinde bu metot tetiklenir..

        // Ctorlar => genelde instance aşamasında default değer set etmek için kullanılır...

        // Ctorlar => metot oldukları için (özel metot) overload edilebilir...
        #endregion
        public Not() // ctoru overload ettik
        {
        }
        public Not(int vize, int final) // ctoru overload ettik
        {
            Vize = vize;
            Final = final;
        }

        public float Vize { get; set; }

        public float Final { get; set; }

        public float Ortalam
        {
            get
            {
                return Vize * 0.4f + Final * 0.6f;
            }
        }
    }
}
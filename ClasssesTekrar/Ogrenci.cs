using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssesTekrar
{
    // class member => classların bütün üyelerine denir..


    // field => class içerisinde (seviyesi) tanımlanan değişkenler denir. Örn, adi,soyad,,not birer fielddır...
    // metot => sınıf içerisinde tanımlanan, içerisinde kod bloğu tutan alt program... örnek bilgiGoster...bilgigösterin içerisinde test isimli değişken ise değişkendir. çünkü test metot çağrılıdığında oluşacaktır. fieldlar ise sınıftan nesne oluşturulduğunda....

    // property=


    // Access modifers =>
    //
    // private => sadece tanımlandığı yer, (class içi)
    // protected= > field gibi sınıf içeriisnde ve sınıftan türetilen sınıflarda (inheritance konusunda değineceğiz...)
    // public => genel. Proje içirisinde ve Proje dışında
    // internal => sadece proje içerisinde
    // protected internal => türetilen sınıfllarda ve proje içerisinde..

    public class Ogrenci
    {
        public string adi;
        public char cinsiyet;
        public float not;
        public void bilgiGoster()
        {
            string test = "bla bla..."; // değişken...
            Console.WriteLine($"{adi} = {cinsiyet} = {not}");
        }
    }
}

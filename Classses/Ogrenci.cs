using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classses
{
    #region tanim
    // class içerisindeki değişken, metot gibi varlıklara class member denir (sınıf üyeleri)... üyeler class seviyesi varlıklardır.. bu üyelerin en temeli değişkenlerdir. bu değişkenlere field denir.. fieldlar sınıf içerisinde verir tutmak için, metotlar işlem yapmak için kullanılır...ama en temel üye herzaman fieldlardır..Sınıf üyeleri oluşturulduğunda default olarak sınıf için oluşturulur. derleyici bunu böyle kabul eder.bizler sınıf üyelerini sınıf dışına açmamız gerekir...

    // sınıf üyelerinin nereden erişilebilir olacağına accsess modifiers (erişim belirleyiciler) ile karar verilir...Bunlar;
    // private, protected, internal, protected internal, public'tir.En sık kullandıklarımız private(özel) ve public (genel).
    // Not : sınıf üyelerinin erişim seviyeleri default private'dır.

    // Ogrenci sınıfı bizim için uygulama tarafında kullanılacak bir veri tiptir.

    // Classlar soyut varlıklardır. classlardan oluşturulan nesneler somut varlıklardır...
    // Classlar referans tiplerdir...
    #endregion

    class Ogrenci
    {
        public string adiSoyAdi;
        public byte yas;
        public char cinsiyet;
    }
}
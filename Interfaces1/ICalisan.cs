using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    #region tanimlar

    // interface üyelerinin erişim seviyeleri olmaz... çünkü bu üyeler interface içerisinde kullanılmayacağı için erişim seviyerli default geneldir..

    // interface içeriside field tanmlanamaz...çünkü interfaceden instance alınamayacğı için fieldın bir anlamı olmaz...

    // interface üyelerinin gövdeleri tanımlanmaz.. abstract üyeler gibi düşünebilirsiniz. ancak bu tanımı yaparken virtual veya abstract olarak işaretlemenize gerek yoktur..gövdesnin tanımlanmama nedeni instance alınamamasıdır.

    // interce üyeleri miras alınan sınıf tarafından implemente edilemek zorundadır....
    #endregion
    public interface ICalisan
    {
        //int gunSayisi;
        decimal Maas { get; set; }

        string IsyeriAdresi();
    }

}

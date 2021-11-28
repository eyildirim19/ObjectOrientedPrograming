using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliymorphism2
{
    public abstract class HayvanlarAlemi
    {
        // abstract üyeler... çok biçimlilik yaklaşımını uygulamak kullanılır. üyenin alt sınıflarda farklı davranmasını sağlar...

        //abstract üyeler gövdesi tanımlanmayan, alt sınıfta tanımlanan üyelerdir...

        // abstract üyeler abstract classlarda tanımlanabilir..

        // abstract üyeler alt sınıflarda implemente (tamamlamak) edilmek zorundadır..
        public abstract string Ses();
        // virtual vs abstract member

        // abstractın gövdesi tanımlanmamalıdır
        // abstract üyeler abstract classlar içerisinde olmalıdır
        // abstractlar alt sınıflar implemente edilmelidir. (implementation'u override lile yaparız..)
        // virtualın gövdesi tanımlanmalıdır
        // alt sınıf tarafından override edilebilir..
    }

    public class Kus : HayvanlarAlemi
    {
        // override komutu ile base'den gelen abstract üyeyi ezmeliyiz..
        public override string Ses()
        {
            // throw new NotImplementedException(); // bu komut override ile metot ezildğinde otomatik yazılır. nedeni metot govdesi boş olsa dahi hata vermemesidir...
            return "Cik Cik Cİk...";
        }
    }

    public class Kedi : HayvanlarAlemi
    {
        public override string Ses()
        {
            return "Miyav Miyaaav";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    /// <summary>
    /// Bazı nesneler vardır ki her bir istek için ayrı ayrı oluşturmaya gerek yoktur.
    /// Örneğin db connection gibi.Her istemci için ayrı ayrı bu nesneyi oluşturmak performans kaybına sebep olacaktır.
    /// Singleton ile oluşturulan nesneler tek bir örnek üzerinde kalır ve her istemci bu örneği kullanır.
    /// Bu tip durumlar için statik class lar da kullanılabilir 
    /// ancak böyle bir kullanımda nesne yönelimli programlama ilkelerine aykırı davranmış oluruz.
    /// Singleton tasarım kalıbını bu şekilde her nesne için uygulayamayız.
    /// Şöyle ki projemizde her kullanıcı için farklı işlemler gerçekleştiren bir class için singleton uygularsak her bir kullanıcı için aynı verileri kullanmış oluruz.
    /// Örneğin her kullanıcının kullanıcı adı aynı olur gibi.
    /// https://csharpindepth.com/Articles/Singleton
    /// </summary>
    /// 
    public sealed class SingletonTreadSafeWithoutLock
    {
        private static readonly SingletonTreadSafeWithoutLock instance = new SingletonTreadSafeWithoutLock();

        static SingletonTreadSafeWithoutLock()
        {
        }

        private SingletonTreadSafeWithoutLock()
        {
        }

        public static SingletonTreadSafeWithoutLock Instance
        {
            get
            {
                return instance;
            }
        }
    }
}

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
    /// Not: Veri tutmayan her nesne için kullanılabilir. Ayrıca sürekli kullanılması gereken bir nesne olmalı ki bellekte gereksiz yere yer işgal etmesin!
    /// https://csharpindepth.com/Articles/Singleton
    /// </summary>
    /// 
    public class Sigleton
    {

        public static void TestSigletonDesignPattern()
        {
            SingletonForDotNetFour singleton1 = SingletonForDotNetFour.Instance;
            SingletonForDotNetFour singleton2 = SingletonForDotNetFour.Instance;

            SingletonTreadSafeWithoutLock singleton3 = SingletonTreadSafeWithoutLock.Instance;
            SingletonTreadSafeWithoutLock singleton4 = SingletonTreadSafeWithoutLock.Instance;


            if (singleton1 == singleton2)
            {
                Console.WriteLine("SingletonForDotNetFour başarılı");
            }
            else
            {
                Console.WriteLine("SingletonForDotNetFour başarısız!!!");
            }


            if (singleton3 == singleton4)
            {
                Console.WriteLine("SingletonTreadSafeWithoutLock başarılı");
            }
            else
            {
                Console.WriteLine("SingletonTreadSafeWithoutLock başarısız!!!");
            }
        }

    }
}

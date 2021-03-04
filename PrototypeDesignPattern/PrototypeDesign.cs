using PrototypeDesignPattern.Concrete;
using System;

namespace PrototypeDesignPattern
{
    /// <summary>
    /// Tasarım deseni yaklaşımlarından Prototype Design Pattern sayesinde elimizdeki mevcut nesnelerin prototiplerini oluşturabilmekte, birnevi bu nesnelerin kopyalarını elde edebilmekteyiz. 
    /// Prototip deseninin tasarlanmasının asıl sebebi, ilgili nesne üzerinden aynı tipte başka bir nesneyi hızlıca üretebilmektir. 
    /// Haliyle üretimi esnasında maliyetli olabilecek nesneleri(ki burada maliyetten kasıt, parametreli constructer vs. olabilir) var olan nesne üzerinden “new” anahtar sözcüğünü kullanmadan bir şekilde oluşturulmasını sağlayabilmektedir.
    /// </summary>

    public class PrototypeDesign
    {


        public static void TestPrototypeDesignPattern()
        {
            Customer c1 = new Customer(3, "Burak", "Halefoglu", true);
            Customer c2 = (Customer)c1.Clone();

            if (c1.Equals(c2))
            {
                Console.WriteLine("Eşit");
            }
            else
            {
                Console.WriteLine("Değil");
            }
        }
 
    }
}

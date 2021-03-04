using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass;
using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Concrete.Mysql;
using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Concrete.Sqlite;
using AbstractFactoryDesignPattern.AbstractFactoryWithInterface;
using AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Concrete.Mysql;
using AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Concrete.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    /// <summary>
    /// Fabrika olarak düşünürsek, Factory DP sadece tek bir ürünün üretildiği fabrika,
    /// Abstract Factory DP ise farklı farklı ürünlerin üretildiği fabrika olarak düşünebiliriz.
    /// Birden fazla ürün ailesi ile çalışmak durumunda kaldığımızda , ürün ailesi ile istemci tarafını soyutlamak için kullanılır.
    /// Ürün ailelerinin oluşumunu istemci tarafından ayırarak, karar verme koşulu olmadan, 
    /// esnek ve geliştirilebilir bir yapı kurmamızı sağlar.
    /// </summary>
    public class AbstractFactory
    {
        public static void TestAbstractFactoryDesignPattern()
        {

            AbstractFactoryWithAbstractClasses MySql = new AbstractFactoryWithAbstractClasses(new MySqlDatabase());
            AbstractFactoryWithAbstractClasses Sqlite = new AbstractFactoryWithAbstractClasses(new SqLiteDatabase());
            Console.WriteLine("|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|");
            AbstractFactoryMethotWithInterface MySql2 = new AbstractFactoryMethotWithInterface(new MySqlDatabaseOherVersion());
            AbstractFactoryMethotWithInterface Sqlite2 = new AbstractFactoryMethotWithInterface(new SqLiteDatabaseOherVersion());


        }
    }
}

using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Concrete.Mysql
{
    public class MySqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("Mysql bağlantısı başarılı");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("Mysql çıkışı başarılı");
            return true;
        }
    }
}

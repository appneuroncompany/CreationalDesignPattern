using AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Concrete.Mysql
{
    public class MySqlConnection : IConnection
    {
        public string State => "Open";

        public bool Connect()
        {
            Console.WriteLine("Mysql bağlantısı başarılı");
            return true;
        }

        public bool DisConnect()
        {
            Console.WriteLine("Mysql çıkışı başarılı");
            return true;
        }
    }
}

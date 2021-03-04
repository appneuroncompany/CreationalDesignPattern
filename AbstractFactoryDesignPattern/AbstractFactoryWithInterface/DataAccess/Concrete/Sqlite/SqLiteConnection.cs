using AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Concrete.Sqlite
{
    public class SqLiteConnection : IConnection
    {
        public string State => "Open";

        public bool Connect()
        {
            Console.WriteLine("Sqlite bağlantısı başarılı");
            return true;
        }

        public bool DisConnect()
        {
            Console.WriteLine("Sqlite çıkışı başarılı");
            return true;
        }
    }
}

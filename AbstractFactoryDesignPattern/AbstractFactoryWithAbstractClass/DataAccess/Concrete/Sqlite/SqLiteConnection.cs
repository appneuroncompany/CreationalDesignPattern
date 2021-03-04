using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Concrete.Sqlite
{
    class SqLiteConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("Sqlite bağlantısı başarılı");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("Sqlite çıkışı başarılı");
            return true;
        }
    }
}

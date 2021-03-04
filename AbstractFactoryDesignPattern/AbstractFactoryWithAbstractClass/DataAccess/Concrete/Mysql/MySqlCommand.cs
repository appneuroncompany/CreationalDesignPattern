using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Concrete.Mysql
{
    public class MySqlCommand : Command
    {
        public override void Execute(string query) => Console.WriteLine("MysqlCommand sorgusu çalıştırıldı.");
    }
}

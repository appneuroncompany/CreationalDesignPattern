using AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Concrete.Mysql
{
    public class MySqlCommand : ICommand
    {
        public void Execute(string query) => Console.WriteLine("MysqlCommand sorgusu çalıştırıldı.");
    }
}


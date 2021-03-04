using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Concrete.Mysql
{
    public  class MySqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand() => new MySqlCommand();
        public override Connection CreateConnection() => new MySqlConnection();
    }
}

using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract;
using AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Concrete.Mysql
{
    public class MySqlDatabaseOherVersion : IDatabaseFactory
    {
        public ICommand CreateCommand()
        {
            return new MySqlCommand();
        }

        public IConnection CreateConnection()
        {
            return new MySqlConnection();
        }

        
    }
}

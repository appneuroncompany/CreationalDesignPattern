using AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Concrete.Sqlite
{
    public class SqLiteDatabaseOherVersion : IDatabaseFactory
    {
        public ICommand CreateCommand()
        {
            return new SqLiteCommand();
        }

        public IConnection CreateConnection()
        {
            return new SqLiteConnection();
        }
    }
}

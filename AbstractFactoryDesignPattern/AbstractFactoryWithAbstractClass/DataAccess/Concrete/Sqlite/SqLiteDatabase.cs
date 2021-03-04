using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Concrete.Sqlite
{
    public class SqLiteDatabase : DatabaseFactory
    {
        public override Command CreateCommand() => new SqLiteCommand();
        public override Connection CreateConnection() => new SqLiteConnection();
    }
}

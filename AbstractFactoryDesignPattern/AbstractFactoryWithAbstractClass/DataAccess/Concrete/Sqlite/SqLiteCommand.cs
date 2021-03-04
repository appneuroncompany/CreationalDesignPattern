using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Concrete.Sqlite
{

    public class SqLiteCommand : Command
    {
        public override void Execute(string query) => Console.WriteLine("SqLiteCommand sorgusu çalıştırıldı.");
    }
}

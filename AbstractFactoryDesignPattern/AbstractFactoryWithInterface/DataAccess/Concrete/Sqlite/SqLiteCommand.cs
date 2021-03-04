using AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Concrete.Sqlite
{
    public class SqLiteCommand : ICommand
    {
        public void Execute(string query) => Console.WriteLine("SqLiteCommand sorgusu çalıştırıldı.");

    }
}

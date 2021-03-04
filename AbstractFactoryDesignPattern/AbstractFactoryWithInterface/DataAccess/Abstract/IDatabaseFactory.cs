using AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Abstract
{
    public interface IDatabaseFactory
    {
        public IConnection CreateConnection();
        public ICommand CreateCommand();
    }
}

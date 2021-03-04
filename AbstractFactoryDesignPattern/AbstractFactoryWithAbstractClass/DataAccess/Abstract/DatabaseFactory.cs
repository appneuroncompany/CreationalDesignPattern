using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract
{
    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract
{
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool DisConnect();
        public abstract string State { get; }
    }
}

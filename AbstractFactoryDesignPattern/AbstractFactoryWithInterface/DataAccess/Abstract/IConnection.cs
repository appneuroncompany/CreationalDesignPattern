using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Abstract
{
    public interface IConnection
    {
        public bool Connect();
        public bool DisConnect();
        public string State { get; }
    }
}

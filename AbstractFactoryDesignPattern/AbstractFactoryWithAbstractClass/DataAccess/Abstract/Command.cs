using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithAbstractClass.DataAccess.Abstract
{
    public abstract class Command
    {
        public abstract void Execute(string query);
    }
}

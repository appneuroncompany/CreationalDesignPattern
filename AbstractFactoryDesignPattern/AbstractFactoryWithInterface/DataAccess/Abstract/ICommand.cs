using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.AbstractFactoryWithInterface.DataAccess.Abstract
{
    public interface ICommand
    {
        void Execute(string query);
    }
}

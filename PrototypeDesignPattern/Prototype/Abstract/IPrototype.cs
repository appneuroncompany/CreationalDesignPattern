using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern.Prototype.Abstract
{
   public interface IPrototype
    {
        IPrototype Clone();
    }
}

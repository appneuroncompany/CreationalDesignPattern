using PrototypeDesignPattern.Prototype.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDesignPattern.Concrete
{

    public class Customer : IPrototype
    {
        public int _id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public bool state { get; set; }
        public Customer(int _id, string name, string surname, bool state)
        {
            this._id = _id;
            this.name = name;
            this.surname = surname;
            this.state = state;
        }

        public IPrototype Clone()
        {
            return this.MemberwiseClone() as IPrototype;
        }
    }
}

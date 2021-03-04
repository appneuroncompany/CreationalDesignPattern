
using System;
using SingletonDesignPattern;
using PrototypeDesignPattern;
using BuilderDesignPattern;
using AbstractFactoryDesignPattern;

namespace DesignPatternTest
{
    class Program
    {
        /// <summary>
        /// Any fool can write code that a computer can understand. 
        /// Good programmers write code that humans can understand.
        /// </summary>
        /// <param Author="Martin Fowler"></param>
        static void Main(string[] args)
        {

            Sigleton.TestSigletonDesignPattern();
            AbstractFactory.TestAbstractFactoryDesignPattern();
            PrototypeDesign.TestPrototypeDesignPattern();
            BuilderDesign.TestBuilderDesignPattern();

        }

    }
}

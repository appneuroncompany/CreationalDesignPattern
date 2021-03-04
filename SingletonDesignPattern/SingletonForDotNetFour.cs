using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{

    public sealed class SingletonForDotNetFour
    {
        private static readonly Lazy<SingletonForDotNetFour> lazy =
            new Lazy<SingletonForDotNetFour>(() => new SingletonForDotNetFour());

        public static SingletonForDotNetFour Instance { get { return lazy.Value; } }

        private SingletonForDotNetFour()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonAllType
{
    public sealed class Singleton5
    {
        Singleton5()
        {
        }

        public static Singleton5 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }
            internal static readonly Singleton5 instance = new Singleton5();
        }
    }
}

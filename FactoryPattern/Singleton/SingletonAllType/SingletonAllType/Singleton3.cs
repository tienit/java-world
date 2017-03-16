using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonAllType
{
    public sealed class Singleton3
    {
        static Singleton3 instance = null;
        static readonly object padlock = new object();
        Singleton3()
        {
        }

        public static Singleton3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton3();
                        }
                    }
                }
                return instance;
            }
        }
    }
}

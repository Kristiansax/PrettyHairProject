using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Core.KeyGenerators
{
    class DateKeyGenerator
    {
        // static members
        private static volatile DateKeyGenerator instance;
        private static object synchronizationRoot = new Object();

        public static DateKeyGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new DateKeyGenerator();
                        }
                    }
                }
                return instance;
            }
        }


        // instance variables
        private int nextKey;

        // private constructor
        private DateKeyGenerator()
        {
        }

        // instance methods
        public virtual int NextKey
        {
            get
            {
                nextKey = Convert.ToInt32(DateTime.Now);
                return nextKey / 20;
            }
        }
    }
}

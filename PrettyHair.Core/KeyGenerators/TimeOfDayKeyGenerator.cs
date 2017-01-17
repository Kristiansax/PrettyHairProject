using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.Core.KeyGenerators
{
    class TimeOfDayKeyGenerator
    {
        // static members
        private static volatile TimeOfDayKeyGenerator instance;
        private static object synchronizationRoot = new Object();

        public static TimeOfDayKeyGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new TimeOfDayKeyGenerator();
                        }
                    }
                }
                return instance;
            }
        }


        // instance variables
        private int nextKey;

        // private constructor
        private TimeOfDayKeyGenerator()
        {
        }

        // instance methods
        public virtual int NextKey
        {
            get
            {
                nextKey = Convert.ToInt32(DateTime.Now.TimeOfDay);
                return nextKey / 10;
            }
        }
    }
}

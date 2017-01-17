using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.Core.KeyGenerators
{
    [Serializable]
    class EntityKeyGenerator : IKeyGenerator
    {
        // static members
        private static volatile EntityKeyGenerator instance;
        private static object synchronizationRoot = new Object();

        public static EntityKeyGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new EntityKeyGenerator();
                        }
                    }
                }
                return instance;
            }
        }


        // instance variables
        private int nextKey;

        // private constructor
        private EntityKeyGenerator()
        {
        }

        // instance methods
        public virtual int NextKey
        {
            get
            {
                return ++nextKey;
            }
        }
    }
}

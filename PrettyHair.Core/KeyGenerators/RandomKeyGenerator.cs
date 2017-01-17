using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.Core.KeyGenerators
{
    public class RandomKeyGenerator : IKeyGenerator
    {
        // static members
        List<int> numbersUsed = new List<int>();
        private static volatile RandomKeyGenerator instance;
        private static object synchronizationRoot = new Object();

        public static RandomKeyGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new RandomKeyGenerator();
                        }
                    }
                }
                return instance;
            }
        }


        // instance variables
        private int nextKey;

        // private constructor
        private RandomKeyGenerator()
        {
        }

        // instance methods
        Random r = new Random();
        public virtual int NextKey
        {
            get
            {
                GetNextKey();
                return nextKey;
            }
        }

        public void GetNextKey()
        {
            nextKey = r.Next(1, 1000);
            while (numbersUsed.Contains(nextKey))
            {
                nextKey = r.Next(1, 1000);
            }
            numbersUsed.Add(nextKey);
        }
    }
}
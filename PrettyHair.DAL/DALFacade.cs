using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair.DAL.Facade
{
    class DALFacade
    {
        private static volatile DALFacade instance;

        public static DALFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DALFacade();
                }

                return instance;
            }
        }

        private DALFacade()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Entities;
using PrettyHair.Core.Interfaces;
using PrettyHair.Core.Repositories;

namespace PrettyHair.Core.Facade
{
    [Serializable]
    public class CoreFacade
    {
        private static volatile CoreFacade instance;

        public static CoreFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CoreFacade();
                    {

                    }
                }
                return instance;
            }
        }
        private CoreFacade()
        {
        }

        CustomerRepository CustomerRepo = new CustomerRepository();
        ItemRepository ItemRepo = new ItemRepository();
        OrderlineRepository OrderlineRepo = new OrderlineRepository();
        OrderRepository OrderRepo = new OrderRepository();

        public void CreateCustomer()
        {
            ICustomer abemand;
            CustomerRepo.CreateCustomer(abemandx);
        }

    }
}

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

        private CustomerRepository CustomerRepo;
        private ItemRepository ItemRepo;
        private OrderlineRepository OrderlineRepo;
        private OrderRepository OrderRepo;

        private CoreFacade()
        {
            CustomerRepo = new CustomerRepository();
            ItemRepo = new ItemRepository();
            OrderlineRepo = new OrderlineRepository();
            OrderRepo = new OrderRepository();
        }

        //CustomerRepository 
        public void CreateCustomer(string firstname, string lastname)
        {
            
            Customer customer = new Customer(firstname,lastname);
            customer.Firstname = firstname;
            customer.Lastname = lastname;
            
            CustomerRepo.CreateCustomer(customer);
        }

        public void RemoveCustomerByID(int ID)
        {
            CustomerRepo.RemoveCustomerByID(ID);
        }

        public void CustomerClear()
        {
            CustomerRepo.Clear();
        }

        public ICustomer GetCustomerByID(int ID)
        {
            return CustomerRepo.GetCustomerByID(ID);
        }

        public int GetCount()
        {
            return CustomerRepo.GetCount();
        }

        //OrderRepository
        public void CreateOrder(DateTime deliverydate, DateTime orderdate)
        {

            IOrder order = new Order(deliverydate, orderdate);
            order.DeliveryDate = deliverydate;
            order.OrderDate = orderdate;
            OrderRepo.CreateOrder(order);
        }

        public void RemoveOrderByID(int ID)
        {
            OrderRepo.RemoveByID(ID);
        }

        public void OrderClear()
        {
            OrderRepo.Clear();
        }

        public void GetOrderByID(int ID)
        {
            OrderRepo.GetOrderByID(ID);
        }

        //OrderlineRepository
        public void CreateOrderline(IOrderline orderline)
        {
            OrderlineRepo.CreateOrderline(orderline);
        }
        public void RemoveOrderlineByID(int ID)
        {
            OrderlineRepo.RemoveByID(ID);
        }
        public void OrderlineClear()
        {
            OrderlineRepo.Clear();
        }
        public void GetOrderlineByID(int ID)
        {
            OrderlineRepo.GetOrderlineByID(ID);
        }

    }
}

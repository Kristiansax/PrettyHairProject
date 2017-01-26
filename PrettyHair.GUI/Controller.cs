using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyHair.Core.Entities;
using PrettyHair.Core.Repositories;
using PrettyHair.Core.Interfaces;

namespace PrettyHair.GUI
{
    public class Controller
    {
        private static Controller instance;
        private CustomerRepository repository;
        public ICustomer CurrentCustomer { get; private set; }
        public int CustomerCount { get; private set; }
        int ID = 0;

        public Controller()
        {
            CurrentCustomer = null;
            CustomerRepository repository = new CustomerRepository();
            CustomerCount = 0;
        }
        public static Controller GetInstance()
        {
            if (instance == null)
            {
                instance = new Controller();
            }
            return instance;
        }

        public void AddCustomer(string FirstName, string LastName)
        {

            Customer customer = new Customer(FirstName, LastName);
            CurrentCustomer = customer;
            Core.Facade.CoreFacade.Instance.CreateCustomer(FirstName, LastName);
            CustomerCount = repository.GetCount();

        }
        public void DeletePerson()
        {
            if (CurrentCustomer != null)
            {
                ID = repository.ReturnID();
                repository.RemoveCustomerByID(ID);
                CustomerCount = repository.GetCount();
                CurrentCustomer = repository.GetCustomerByID(ID);
                /*if (PersonIndex == -1)
                {
                    PersonIndex++;
                    CurrentPerson = repository.GetPersonAtIndex(PersonIndex);
                    if (PersonCount == 0)
                    {
                        PersonIndex--;

                    }
                }*/
            }
        }

        public void NextCustomer()
        {
            ID = repository.ReturnID();
            if (ID < CustomerCount - 1)
            {
                ID = repository.ReturnID();
                CurrentCustomer = repository.GetCustomerByID(ID);
            }
        }
        public void PreviousPerson()
        {
            ID = repository.ReturnID();
            if (ID > 0)
            {
                CurrentCustomer = repository.GetCustomerByID(ID);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;


            foundCustomer = customerList.FirstOrDefault(c =>
                                c.CustomerId == customerId);



            return foundCustomer;

        }

        public List<Customer> Retrieve()
        {

            List<Customer> charList = new List<Customer>
                    {new Customer()
                          { CustomerId = 1,
                            FirstName="Ahsoka",
                            LastName = "Tano",
                            EmailAddress = "at@hob.me",
                            CustomerTypeId=1},
                    new Customer()
                          { CustomerId = 2,
                            FirstName="Anakin",
                            LastName = "Skywalker",
                            EmailAddress = "as@hob.me",
                            CustomerTypeId=2},
                    new Customer()
                          { CustomerId = 3,
                            FirstName="Darth",
                            LastName = "Vader",
                            EmailAddress = "dv@hob.me",
                            CustomerTypeId=3},
                    new Customer()
                          { CustomerId = 4,
                            FirstName="Han",
                            LastName = "Solo",
                            EmailAddress = "hs@hob.me",
                            CustomerTypeId=4}};
            return charList;
        }
        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName)
                            .ThenBy(c => c.FirstName);
        }
        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName)
            //                    .ThenByDescending(c => c.FirstName);

            //Lub
            return SortByName(customerList).Reverse();
        }
        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.CustomerTypeId);
            //return characterList.OrderByDescending(c => c.CustomerTypeId.HasValue)
            //                    .ThenBy(c => c.CustomerTypeId);
        }
        
    }
}

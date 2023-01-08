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
            List<Customer> custList = new List<Customer>
                    {new Customer()
                          { CustomerId = 1,
                            FirstName="Luke",
                            LastName = "Skywalker",
                            EmailAddress = "ls@hob.me",
                            CustomerTypeId=1},
                    new Customer()
                          { CustomerId = 2,
                            FirstName="Anakin",
                            LastName = "Skywalker",
                            EmailAddress = "as@hob.me",
                            CustomerTypeId=null},
                    new Customer()
                          { CustomerId = 3,
                            FirstName="Darth",
                            LastName = "Vader",
                            EmailAddress = "dv@hob.me",
                            CustomerTypeId=1},
                    new Customer()
                          { CustomerId = 4,
                            FirstName="Han",
                            LastName = "Solo",
                            EmailAddress = "hs@hob.me",
                            CustomerTypeId=2}};
            return custList;
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
    }
}

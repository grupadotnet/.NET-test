using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerTypeRepository
    {
        public List<CustomerType> Retrieve()
        {
            List<CustomerType> customerTypeList = new List<CustomerType>
                    {new CustomerType()
                          { CustomerTypeId = 1,
                            TypeName="GrayJedi",
                            DisplayOrder = 2,},
                    new CustomerType()
                          { CustomerTypeId = 2,
                            TypeName="Jedi",
                            DisplayOrder = 1},
                    new CustomerType()
                          { CustomerTypeId = 3,
                            TypeName="Sith",
                            DisplayOrder = 4},
                    new CustomerType()
                          { CustomerTypeId = 4,
                            TypeName="StrongInForce",
                            DisplayOrder = 3}};
            return customerTypeList;
        }
    }
}

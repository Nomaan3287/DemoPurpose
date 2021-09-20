using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPurpose.Models
{
    public class customerMapper
    {
        public static DemoPurpose.Models.customer Map(Data.customer cust)
        {
            return new DemoPurpose.Models.customer()
            {
                Id = cust.customer_Id,
                Name = cust.customer_Name,
                Email = cust.customer_Email,
                Age = cust.customer_Age,
                Phone = cust.customer_Phone,
                Address = cust.customer_Address,
                Password = cust.customer_Password,
                Gender = cust.customer_Gender
            };
        }

        //

        public static Data.customer Maps(DemoPurpose.Models.Registration reg)
        {
            return new Data.customer()
            {
                customer_Name = reg.Name,
                customer_Email = reg.Email,
                customer_Age = reg.Age,
                customer_Phone = reg.Phone,
                customer_Address = reg.Address,
                customer_Password = reg.Password,
                customer_Gender = reg.Gender
         
            };
        }
    }
}
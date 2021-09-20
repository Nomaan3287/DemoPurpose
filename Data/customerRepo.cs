using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class customerRepo
    {
        private BookModel db;
        public customerRepo(BookModel db)
        {
            this.db = db;
        }
        public IEnumerable<customer> GetCustomer()
        {
            return db.customers
                    .ToList();
        }
        public void AddCustomer(customer cust)
        {
            db.customers.Add(cust);
            Save();
        }


        
        public void EditCustomer(int id,customer cust)
        {
            var custEdit = db.customers.Where(m => m.customer_Id == id).FirstOrDefault();
            if (custEdit != null)
            {
                custEdit.customer_Name = cust.customer_Name;
                custEdit.customer_Email = cust.customer_Email ;
                custEdit.customer_Age = cust.customer_Age;
                custEdit.customer_Phone = cust.customer_Phone;
                custEdit.customer_Address = cust.customer_Address ;
                custEdit.customer_Password = cust.customer_Password;
                custEdit.customer_Gender = cust.customer_Gender;
                Save();
            }
           
            
            
        }

        public customer GetCustomerById(int id)
        {
            if (id > 0)
            {
                var data = db.customers.Where(m => m.customer_Id == id).FirstOrDefault();
                return data;
            }
            else
            {
                return null;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}

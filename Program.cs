using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = CustomerDao.CustomersByCountry("USA");
            foreach (var customer in customers)
                Console.WriteLine(customer.ContactName);

            var moreCustomers = CustomerDao.CustomersWhoBoughtProduct(1);
                foreach (var otherCustomer in moreCustomers)
                    Console.WriteLine(otherCustomer.ContactName);
                Console.ReadLine();
            }

        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MM.DataLayer;
namespace Adapter
{
    public static class CustomerDao
    {
        public static List<ICustomer> CustomersByCountry(string country)
        {
            List<ICustomer> result = new List<ICustomer>();
            using (MyModelContainer ctx = new MyModelContainer())
            {
                var entityList = ctx.CustomersByCountry(country).ToList();
                foreach (var entity in entityList)
                {
                    result.Add(new CustomersByCountry_Result_Adapter(entity));
                }
            }
            return result;
        }

        public static List<ICustomer> CustomersWhoBoughtProduct(int productId)
        {
            List<ICustomer> result = new List<ICustomer>();
            using (MyModelContainer ctx = new MyModelContainer())
            {
                var entityList = ctx.CustomersWhoBoughtProduct(productId).ToList();
                foreach (var entity in entityList)
                {
                    result.Add(new CustomersWhoBoughtProduct_Result_Adapter(entity));
                }
            }
            return result;
        }
    }
}
